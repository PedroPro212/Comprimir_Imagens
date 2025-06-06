import os
import sys
import threading
from tkinter import Tk, Label, Button, filedialog, messagebox, Frame, PhotoImage, StringVar, Radiobutton
from PIL import Image, ImageTk
from pathlib import Path
from shutil import copyfile

nivel_compressao = 'media'  # padrão

def comprimir_imagem(caminho_entrada, caminho_saida):
    try:
        imagem = Image.open(caminho_entrada)
        imagem = imagem.convert("RGB")

        if nivel_compressao == 'basica':
            qual_inicial, qual_final, passo = 95, 85, -1
        elif nivel_compressao == 'media':
            qual_inicial, qual_final, passo = 85, 60, -5
        else:
            qual_inicial, qual_final, passo = 60, 20, -5

        for qualidade in range(qual_inicial, qual_final, passo):
            imagem.save(caminho_saida, format="JPEG", quality=qualidade)
            tamanho_kb = os.path.getsize(caminho_saida) / 1024
            if tamanho_kb < 500:
                break
        return True
    except Exception as e:
        print(f"Erro ao comprimir {caminho_entrada}: {e}")
        return False

def processar_imagens(pasta_origem):
    imagens = [f for f in os.listdir(pasta_origem) if f.lower().endswith(('.jpg', '.jpeg', '.png'))]
    if not imagens:
        messagebox.showwarning("Aviso", "Nenhuma imagem encontrada na pasta selecionada.")
        return

    pasta_downloads = Path.home() / "Downloads"
    pasta_saida = pasta_downloads / "Comprimidas"
    pasta_saida.mkdir(parents=True, exist_ok=True)

    contador = 0
    for nome_arquivo in imagens:
        caminho_original = os.path.join(pasta_origem, nome_arquivo)
        nome_saida = os.path.splitext(nome_arquivo)[0] + "_comprimida.jpg"
        caminho_saida = os.path.join(pasta_saida, nome_saida)

        sucesso = comprimir_imagem(caminho_original, caminho_saida)
        if sucesso:
            contador += 1
        else:
            copyfile(caminho_original, caminho_saida)

    messagebox.showinfo("Concluído", f"{contador} imagem(s) comprimidas com sucesso!\nSalvas em: {pasta_saida}")

def selecionar_pasta():
    pasta_origem = filedialog.askdirectory()
    if not pasta_origem:
        return

    # Roda em thread para não travar a GUI
    threading.Thread(target=processar_imagens, args=(pasta_origem,), daemon=True).start()

# GUI
janela = Tk()
janela.title("Compressor de Imagens")

largura, altura = 400, 400
largura_tela = janela.winfo_screenwidth()
altura_tela = janela.winfo_screenheight()
pos_x = (largura_tela // 2) - (largura // 2)
pos_y = (altura_tela // 2) - (altura // 2)
janela.geometry(f"{largura}x{altura}+{pos_x}+{pos_y}")
janela.resizable(False, False)

frame = Frame(janela)
frame.place(relx=0.5, rely=0.5, anchor="center")

try:
    if hasattr(sys, '_MEIPASS'):
        caminho_logo = os.path.join(sys._MEIPASS, "logo.png")
    else:
        caminho_logo = os.path.join(os.path.abspath("."), "logo.png")

    imagem_logo = Image.open(caminho_logo)
    imagem_logo = imagem_logo.resize((80, 80))
    logo = ImageTk.PhotoImage(imagem_logo)
    Label(frame, image=logo).pack(pady=(0, 10))
except Exception as e:
    print(f"Erro ao carregar a logo: {e}")

Label(frame, text="Compressor de Imagens", font=("Arial", 16, "bold")).pack(pady=(0, 20))
Label(frame, text="Escolha o nível de compressão:", font=("Arial", 12)).pack(pady=(0,10))

# Variável Tkinter para guardar o valor selecionado
var_nivel = StringVar(value='media')

Radiobutton(frame, text="Compressão Básica", variable=var_nivel, value='basica', font=("Arial", 12)).pack(anchor="w")
Radiobutton(frame, text="Compressão Média", variable=var_nivel, value='media', font=("Arial", 12)).pack(anchor="w")
Radiobutton(frame, text="Compressão Máxima", variable=var_nivel, value='maxima', font=("Arial", 12)).pack(anchor="w")

Label(frame, text="Clique abaixo para escolher a pasta com imagens:", font=("Arial", 12)).pack(pady=(20,10))
Button(frame, text="Selecionar Pasta", font=("Arial", 12), command=lambda: selecionar_pasta_com_nivel()).pack(pady=(0, 20))

def selecionar_pasta_com_nivel():
    global nivel_compressao
    nivel_compressao = var_nivel.get()
    selecionar_pasta()

janela.mainloop()
