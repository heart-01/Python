from PIL.ImageOps import grayscale
from PIL import Image
from pyautogui import *
import pyautogui as pg
from numpy import double, integer, random
from time import gmtime, localtime, strftime
import threading
import subprocess
import requests
import sys
import os
from datetime import datetime, timezone, timedelta



tz = timezone(timedelta(hours = 7))
timenow = datetime.now(tz=tz)

def Openbox():
     while 1:

         if pg.locateCenterOnScreen('confirm.png' ,confidence=0.9) != None:
            print(strftime("%Y-%m-%d %H:%M:%S", localtime())+" | =>""[Moveto Button Confirm]")
            
def Main_Program():
        cf = pg.confirm(text='Bot bomb V.Custom', title='BOT', buttons=["เริ่ม"])
        if cf == 'เริ่ม':
           print("ttttttts")
           Openbox()
        else: exit()   

if __name__ == "__main__":
    Main_Program()