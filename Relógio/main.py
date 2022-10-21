from cProfile import label
from logging import root
from operator import imod
import string
from tkinter import *
from tkinter.ttk import *

from time import strftime
from unittest import TextTestResult

root = Tk()
root.title("Relógio")

def tempo():
    string = strftime('%H:%M:%S %p')
    label.config(text=string)
    label.after(1000, tempo)

label = Label(root, font=("ds-digital", 80), background="black", foreground="cyan")
label.pack(anchor='center')
tempo()

mainloop()