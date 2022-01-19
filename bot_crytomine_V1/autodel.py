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
        if pg.locateCenterOnScreen('del.png' ,confidence=0.8) != None:
            print(strftime("%Y-%m-%d %H:%M:%S", localtime())+" | =>""[Moveto Button Open]")
            pg.moveTo(pg.locateCenterOnScreen('del.png' ,confidence=0.7))
            time.sleep(1)
            print(strftime("%Y-%m-%d %H:%M:%S", localtime())+" | =>""[Moveto Button Confirm]")
            click(pg.locateCenterOnScreen('del.png' ,confidence=0.8))
           
         
        if pg.locateCenterOnScreen('process.png' ,confidence=0.7) != None:
            print(strftime("%Y-%m-%d %H:%M:%S", localtime())+" | =>""[Moveto Button Open]")
            pg.moveTo(pg.locateCenterOnScreen('process.png' ,confidence=0.7))
            print(strftime("%Y-%m-%d %H:%M:%S", localtime())+" | =>""[Moveto Button Confirm]")
            click(pg.locateCenterOnScreen('del.png' ,confidence=0.7))
            time.sleep(1)

def Main_Program():
        cf = pg.confirm(text='Bot bomb V.Custom', title='BOT', buttons=["เริ่ม"])
        if cf == 'เริ่ม':
           Openbox()
        else: exit()   

if __name__ == "__main__":
    Main_Program()