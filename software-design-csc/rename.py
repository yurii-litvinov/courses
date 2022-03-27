import os
import glob

files = list(map(os.path.abspath, glob.glob("./*/* — копия.png"))) \
    + list(map(os.path.abspath, glob.glob("./*/* - Copy.png")))

for fileName in files:
    newFileName = fileName.replace(" — копия", "Black").replace(" - Copy", "Black")
    os.rename(fileName, newFileName)
