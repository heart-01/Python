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
         if pg.locateCenterOnScreen('worker.png' ,confidence=0.9) != None:
            print(strftime("%Y-%m-%d %H:%M:%S", localtime())+" | =>""[Moveto Button box]")
            pg.moveTo(pg.locateCenterOnScreen('worker.png' ,confidence=0.9))
            time.sleep(1)
            click(pg.locateCenterOnScreen('worker.png' ,confidence=0.9))
            time.sleep(2)
            pg.moveTo(pg.locateCenterOnScreen('revealnft.png' ,confidence=0.9))
            time.sleep(1)
            click(pg.locateCenterOnScreen('revealnft.png' ,confidence=0.9))
            time.sleep(1)
            pg.press("down",presses=5)

            if pg.locateCenterOnScreen('error1.png' ,confidence=0.9) != None:
               print(strftime("%Y-%m-%d %H:%M:%S", localtime())+" | =>""[Error!!]")    
               print(strftime("%Y-%m-%d %H:%M:%S", localtime())+" | =>""[Moveto Button Reject]")
               pg.moveTo(pg.locateCenterOnScreen('reject.png' ,confidence=0.7))
               time.sleep(2)
               click(pg.locateCenterOnScreen('reject.png' ,confidence=0.7))
               time.sleep(3)
               Openbox()

            if pg.locateCenterOnScreen('confirm.png' ,confidence=0.9) != None:
               print(strftime("%Y-%m-%d %H:%M:%S", localtime())+" | =>""[Moveto Button Confirm]")
               pg.moveTo(pg.locateCenterOnScreen('confirm.png' ,confidence=0.7))
               time.sleep(2)
               click(pg.locateCenterOnScreen('confirm.png' ,confidence=0.7))
               time.sleep(3)

         else : time.sleep(5)
            
def Main_Program():
        cf = pg.confirm(text='Bot bomb V.Custom', title='BOT', buttons=["เริ่ม"])
        if cf == 'เริ่ม':
           Openbox()
           while 1 : 
                  if pg.locateCenterOnScreen('success_worker.png' ,confidence=0.9) != None:
                     Openbox()
                  
                  if pg.locateCenterOnScreen('cancel.png' ,confidence=0.9) != None:
                         Openbox()
        else: exit()   

if __name__ == "__main__":
    Main_Program()