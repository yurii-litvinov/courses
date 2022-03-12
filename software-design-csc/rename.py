import os
import glob

files = list(map(os.path.abspath, glob.glob("./*/* — копия.png")))

for fileName in files:
    newFileName = fileName.replace(" — копия", "Black")
    os.rename(fileName, newFileName)
