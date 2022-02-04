from fileinput import filename
import os
import glob

for fileName in glob.glob("*/*.tex"):
    dirname, filename = os.path.dirname(fileName), os.path.basename(fileName)
    os.chdir(dirname)
    os.system("xelatex --shell-escape " + filename)
    os.system("xelatex --shell-escape " + filename)
    os.chdir("..")
