from tkinter import Frame,Label,Entry,Button,YES,BOTH,END,Tk,W

class FrmTrapesium:
    def __init__(self, parent, title):
        self.parent = parent
        self.parent.geometry("400x500")
        self.parent.title(title)
        self.parent.protocol("WM_DELETE_WINDOW", self.onKeluar)
        self.aturKomponen()

    def aturKomponen(self):
        mainFrame = Frame(self.parent, bd=10)
        mainFrame.pack(fill=BOTH, expand=YES)

        # pasang Label
        Label(mainFrame, text='Sisi A:').grid(row=0, column=0, sticky=W, padx=5, pady=5)
        Label(mainFrame, text='Sisi B:').grid(row=1, column=0, sticky=W, padx=5, pady=5)
        Label(mainFrame, text='Sisi C:').grid(row=2, column=0, sticky=W, padx=5, pady=5)
        Label(mainFrame, text='Sisi D:').grid(row=3, column=0, sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Tinggi:").grid(row=4, column=0, sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Luas:").grid(row=6, column=0, sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Keliling:").grid(row=7, column=0, sticky=W, padx=5, pady=5)

        # pasang textbox
        self.txtA = Entry(mainFrame)
        self.txtA.grid(row=0, column=1, padx=5, pady=5)

        self.txtB = Entry(mainFrame)
        self.txtB.grid(row=1, column=1, padx=5, pady=5)

        self.txtC = Entry(mainFrame)
        self.txtC.grid(row=2, column=1, padx=5, pady=5)

        self.txtD = Entry(mainFrame)
        self.txtD.grid(row=3, column=1, padx=5, pady=5)

        self.txtTinggi = Entry(mainFrame)
        self.txtTinggi.grid(row=4, column=1, padx=5, pady=5)

        self.txtLuas = Entry(mainFrame)
        self.txtLuas.grid(row=6, column=1, padx=5, pady=5)

        self.txtKeliling = Entry(mainFrame)
        self.txtKeliling.grid(row=7, column=1, padx=5, pady=5)

        # Pasang Button
        self.btnHitung = Button(mainFrame, text='Hitung', command=self.onHitung)
        self.btnHitung.grid(row=5, column=1, padx=5, pady=5)

    # fungsi untuk menghitung luas dan keliling persegi panjang
    def onHitung(self, event=None):

        # perhitungan dengan metode Pemrograman Tidak Terstruktur
        a = int(self.txtA.get())
        b = int(self.txtB.get())
        c = int(self.txtC.get())
        d = int(self.txtD.get())
        tinggi = int(self.txtTinggi.get())

        luas = ((a + c) * tinggi) / 2
        self.txtLuas.delete(0,END)
        self.txtLuas.insert(END,str(luas))

        kel = a + b + c + d
        self.txtKeliling.delete(0,END)
        self.txtKeliling.insert(END,str(kel))

    def onKeluar(self, event=None):
        # memberikan perintah menutup aplikasi
        self.parent.destroy()

if __name__ == '__main__':
    root = Tk()
    aplikasi = FrmTrapesium(root, "Program Luas dan Keliling Trapesium")
    root.mainloop()