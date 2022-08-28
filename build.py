from fileinput import filename
import os
import glob
import sys

directory = sys.argv[1]
files = list(map(os.path.abspath, glob.glob(directory + "/*/*.tex")))

for fileName in files:
    dirname, filename = os.path.dirname(fileName), os.path.basename(fileName)
    if not os.path.basename(dirname).startswith("_"):
        os.chdir(dirname)
        os.system("xelatex --shell-escape " + filename)
        os.system("xelatex --shell-escape " + filename)
