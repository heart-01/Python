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
         if pg.locateCenterOnScreen('box.png' ,confidence=0.9) != None:
            print(strftime("%Y-%m-%d %H:%M:%S", localtime())+" | =>""[Moveto Button box]")
            pg.moveTo(pg.locateCenterOnScreen('box.png' ,confidence=0.9))
            time.sleep(1)
            click(pg.locateCenterOnScreen('box.png' ,confidence=0.9))
            time.sleep(4)
            pg.moveTo(pg.locateCenterOnScreen('mint.png' ,confidence=0.9))
            time.sleep(1)
            click(pg.locateCenterOnScreen('mint.png' ,confidence=0.9))
            time.sleep(2)
            click(pg.locateCenterOnScreen('edit.png' ,confidence=0.9))
            time.sleep(2)
            click(pg.locateCenterOnScreen('gas.png' ,confidence=0.9))
            time.sleep(2)
            click(pg.locateCenterOnScreen('5.png' ,confidence=0.9))
            time.sleep(2)
            pg.hotkey('ctrl', 'a')
            time.sleep(2)
            pg.write('5.1')
            time.sleep(1)
            click(pg.locateCenterOnScreen('save.png' ,confidence=0.9))
            time.sleep(2)
            click(pg.locateCenterOnScreen('mint.png' ,confidence=0.9))
            time.sleep(2)
            pg.press("down",presses=5)
            print(strftime("%Y-%m-%d %H:%M:%S", localtime())+" | =>""[Moveto Button Confirm]")
            pg.moveTo(pg.locateCenterOnScreen('confirm.png' ,confidence=0.7))
            time.sleep(1)
            click(pg.locateCenterOnScreen('confirm.png' ,confidence=0.7))
            time.sleep(3)
         else : time.sleep(5)
            
def Main_Program():
        cf = pg.confirm(text='Bot bomb V.Custom', title='BOT', buttons=["เริ่ม"])
        if cf == 'เริ่ม':
           Openbox()
           while 1 : 
                     if pg.locateCenterOnScreen('success.png' ,confidence=0.9) != None:
                        Openbox()
        else: exit()   

if __name__ == "__main__":
    Main_Program()