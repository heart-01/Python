from pynput.keyboard import Key, Controller

from datetime import datetime
import pytz
import pymsgbox
import sys
import os
import time
import pyautogui as pg
from  tkinter import *

pymsgbox.rootWindowPosition = "+0+0"

keyboard = Controller()

def num1():
    keyboard.press("1")
    keyboard.release("1")
    keyboard.press(Key.enter)
    keyboard.release(Key.enter)  

def num2():
    keyboard.press("2")
    keyboard.release("2")
    keyboard.press(Key.enter)
    keyboard.release(Key.enter)  

def num3():
    keyboard.press("3")
    keyboard.release("3")
    keyboard.press(Key.enter)
    keyboard.release(Key.enter)  

def num4():
    keyboard.press("4")
    keyboard.release("4")
    keyboard.press(Key.enter)
    keyboard.release(Key.enter)  

def num5():
    keyboard.press("5")
    keyboard.release("5")
    keyboard.press(Key.enter)
    keyboard.release(Key.enter)  

def num6():
    keyboard.press("6")
    keyboard.release("6")
    keyboard.press(Key.enter)
    keyboard.release(Key.enter)  

def num7():
    keyboard.press("7")
    keyboard.release("7")
    keyboard.press(Key.enter)
    keyboard.release(Key.enter)  

def num8():
    keyboard.press("8")
    keyboard.release("8")
    keyboard.press(Key.enter)
    keyboard.release(Key.enter)  

def num9():
    keyboard.press("9")
    keyboard.release("9")
    keyboard.press(Key.enter)
    keyboard.release(Key.enter)  

def num0():
    keyboard.press("0")
    keyboard.release("0")
    keyboard.press(Key.enter)
    keyboard.release(Key.enter)  

def num10():
    keyboard.press("1")
    keyboard.release("1")
    keyboard.press("0")
    keyboard.release("0")
    keyboard.press(Key.enter)
    keyboard.release(Key.enter)   

def num11():
    keyboard.press("1")
    keyboard.release("1")
    keyboard.press("1")
    keyboard.release("1")
    keyboard.press(Key.enter)
    keyboard.release(Key.enter)   

def num12():
    keyboard.press("1")
    keyboard.release("1")
    keyboard.press("2")
    keyboard.release("2")
    keyboard.press(Key.enter)
    keyboard.release(Key.enter)   

def num13():
    keyboard.press("1")
    keyboard.release("1")
    keyboard.press("3")
    keyboard.release("3")
    keyboard.press(Key.enter)
    keyboard.release(Key.enter)  

def num14():
    keyboard.press("1")
    keyboard.release("1")
    keyboard.press("4")
    keyboard.release("4")
    keyboard.press(Key.enter)
    keyboard.release(Key.enter)  

def num15():
    keyboard.press("1")
    keyboard.release("1")
    keyboard.press("5")
    keyboard.release("5")
    keyboard.press(Key.enter)
    keyboard.release(Key.enter)  

def num16():
    keyboard.press("1")
    keyboard.release("1")
    keyboard.press("6")
    keyboard.release("6")
    keyboard.press(Key.enter)
    keyboard.release(Key.enter)  

def num17():
    keyboard.press("1")
    keyboard.release("1")
    keyboard.press("7")
    keyboard.release("7")
    keyboard.press(Key.enter)
    keyboard.release(Key.enter)  

def num18():
    keyboard.press("1")
    keyboard.release("1")
    keyboard.press("8")
    keyboard.release("8")
    keyboard.press(Key.enter)
    keyboard.release(Key.enter)  

def num19():
    keyboard.press("1")
    keyboard.release("1")
    keyboard.press("9")
    keyboard.release("9")
    keyboard.press(Key.enter)
    keyboard.release(Key.enter)  

def num20():
    keyboard.press("2")
    keyboard.release("2")
    keyboard.press("0")
    keyboard.release("0")
    keyboard.press(Key.enter)
    keyboard.release(Key.enter)  

def num21():
    keyboard.press("2")
    keyboard.release("2")
    keyboard.press("1")
    keyboard.release("1")
    keyboard.press(Key.enter)
    keyboard.release(Key.enter)  

def num22():
    keyboard.press("2")
    keyboard.release("2")
    keyboard.press("2")
    keyboard.release("2")
    keyboard.press(Key.enter)
    keyboard.release(Key.enter)  

def num23():
    keyboard.press("2")
    keyboard.release("2")
    keyboard.press("3")
    keyboard.release("3")
    keyboard.press(Key.enter)
    keyboard.release(Key.enter)  

def num24():
    keyboard.press("2")
    keyboard.release("2")
    keyboard.press("4")
    keyboard.release("4")
    keyboard.press(Key.enter)
    keyboard.release(Key.enter)  

def num25():
    keyboard.press("2")
    keyboard.release("2")
    keyboard.press("5")
    keyboard.release("5")
    keyboard.press(Key.enter)
    keyboard.release(Key.enter)  

def num26():
    keyboard.press("2")
    keyboard.release("2")
    keyboard.press("6")
    keyboard.release("6")
    keyboard.press(Key.enter)
    keyboard.release(Key.enter)  

def num27():
    keyboard.press("2")
    keyboard.release("2")
    keyboard.press("7")
    keyboard.release("7")
    keyboard.press(Key.enter)
    keyboard.release(Key.enter)  

def num28():
    keyboard.press("2")
    keyboard.release("2")
    keyboard.press("8")
    keyboard.release("8")
    keyboard.press(Key.enter)
    keyboard.release(Key.enter)  

def num29():
    keyboard.press("2")
    keyboard.release("2")
    keyboard.press("9")
    keyboard.release("9")
    keyboard.press(Key.enter)
    keyboard.release(Key.enter)  

def num30():
    keyboard.press("3")
    keyboard.release("3")
    keyboard.press("0")
    keyboard.release("0")
    keyboard.press(Key.enter)
    keyboard.release(Key.enter)  

def num31():
    keyboard.press("3")
    keyboard.release("3")
    keyboard.press("1")
    keyboard.release("1")
    keyboard.press(Key.enter)
    keyboard.release(Key.enter)  

def num32():
    keyboard.press("3")
    keyboard.release("3")
    keyboard.press("2")
    keyboard.release("2")
    keyboard.press(Key.enter)
    keyboard.release(Key.enter)  

def num33():
    keyboard.press("3")
    keyboard.release("3")
    keyboard.press("3")
    keyboard.release("3")
    keyboard.press(Key.enter)
    keyboard.release(Key.enter)  

def num34():
    keyboard.press("3")
    keyboard.release("3")
    keyboard.press("4")
    keyboard.release("4")
    keyboard.press(Key.enter)
    keyboard.release(Key.enter)  

def num35():
    keyboard.press("3")
    keyboard.release("3")
    keyboard.press("5")
    keyboard.release("5")
    keyboard.press(Key.enter)
    keyboard.release(Key.enter)  

def num36():
    keyboard.press("3")
    keyboard.release("3")
    keyboard.press("6")
    keyboard.release("6")
    keyboard.press(Key.enter)
    keyboard.release(Key.enter)  

def num37():
    keyboard.press("3")
    keyboard.release("3")
    keyboard.press("7")
    keyboard.release("7")
    keyboard.press(Key.enter)
    keyboard.release(Key.enter)  

def num38():
    keyboard.press("3")
    keyboard.release("3")
    keyboard.press("8")
    keyboard.release("8")
    keyboard.press(Key.enter)
    keyboard.release(Key.enter)  

def num39():
    keyboard.press("3")
    keyboard.release("3")
    keyboard.press("9")
    keyboard.release("9")
    keyboard.press(Key.enter)
    keyboard.release(Key.enter)  

def num40():
    keyboard.press("4")
    keyboard.release("4")
    keyboard.press("0")
    keyboard.release("0")
    keyboard.press(Key.enter)
    keyboard.release(Key.enter)  

def num41():
    keyboard.press("4")
    keyboard.release("4")
    keyboard.press("1")
    keyboard.release("1")
    keyboard.press(Key.enter)
    keyboard.release(Key.enter) 

def num42():
    keyboard.press("4")
    keyboard.release("4")
    keyboard.press("2")
    keyboard.release("2")
    keyboard.press(Key.enter)
    keyboard.release(Key.enter)   

def num43():
    keyboard.press("4")
    keyboard.release("4")
    keyboard.press("3")
    keyboard.release("3")
    keyboard.press(Key.enter)
    keyboard.release(Key.enter)  

def num44():
    keyboard.press("4")
    keyboard.release("4")
    keyboard.press("4")
    keyboard.release("4")
    keyboard.press(Key.enter)
    keyboard.release(Key.enter)  

def num45():
    keyboard.press("4")
    keyboard.release("4")
    keyboard.press("5")
    keyboard.release("5")
    keyboard.press(Key.enter)
    keyboard.release(Key.enter)  

def num46():
    keyboard.press("4")
    keyboard.release("4")
    keyboard.press("6")
    keyboard.release("6")
    keyboard.press(Key.enter)
    keyboard.release(Key.enter)  

def num47():
    keyboard.press("4")
    keyboard.release("4")
    keyboard.press("7")
    keyboard.release("7")
    keyboard.press(Key.enter)
    keyboard.release(Key.enter)  

def num48():
    keyboard.press("4")
    keyboard.release("4")
    keyboard.press("8")
    keyboard.release("8")
    keyboard.press(Key.enter)
    keyboard.release(Key.enter)  

def num49():
    keyboard.press("4")
    keyboard.release("4")
    keyboard.press("9")
    keyboard.release("9")
    keyboard.press(Key.enter)
    keyboard.release(Key.enter) 

def num50():
    keyboard.press("5")
    keyboard.release("5")
    keyboard.press("0")
    keyboard.release("0")
    keyboard.press(Key.enter)
    keyboard.release(Key.enter)   

def enter():
    keyboard.press(Key.enter)
    keyboard.release(Key.enter)   

def restart():
    print("argv was",sys.argv)
    print("sys.executable was", sys.executable)
    print("restart now")

    os.execv(sys.executable, ['python'] + sys.argv)

def times_multi():
    tz_Bangkok = pytz.timezone('Asia/Bangkok')
    datetime_Bangkok = datetime.now(tz_Bangkok)

    clock.config(text=datetime_Bangkok.strftime("%H:%M:%S"))
    clock.after(200,times_multi)  

root=Tk()
root.geometry("500x250")
clock=Label(root,font=("times",50,"bold"),bg="black",fg='blue')
clock.grid(row=2,column=2,pady=25,padx=100)
times_multi()

digi=Label(root,text="Digital clock",font="times 24 bold",fg="violet")
digi.grid(row=0,column=2)

nota=Label(root,text="hours   minutes   seconds   ",font="times 15 bold")
nota.grid(row=3,column=2)

# root.mainloop()

# ----------------------------------------------- 

def number():
    #line ส่งก่อน 8 ตัว เวลา 00:00:02 เลข 2 ตัวส่งไปก่อน 4 ตัว
    #facebook ส่งก่อน 4 ตัว เวลา 00:00:59
    num15()
    time.sleep(0.060)
    num16()
    time.sleep(0.060)
    num17()
    time.sleep(0.060)
    num18()
    time.sleep(0.060)
    for i in range(int(start),int(stop) + 1, int(1)):
        method = eval("num"+str(i))
        method()
        time.sleep(0.060) # time.sleep(50 / 1000)

    conf = pg.confirm('ส่งข้อความสำเร็จ! \nคุณต้องการเริ่มโปรแกรมใหม่ใช่หรือไม่ ?',buttons=['เริ่มใหม่','ยกเลิก'])
    restart() if conf == 'เริ่มใหม่' else exit()

def setRange():
    for i in range(7):
        keyboard.press("1")
        keyboard.release("1")
        keyboard.press("8")
        keyboard.release("8")
        keyboard.press("-")
        keyboard.release("-")
        keyboard.press("3")
        keyboard.release("3")
        keyboard.press("0")
        keyboard.release("0")
        keyboard.press(Key.enter)
        keyboard.release(Key.enter)   
        time.sleep(0.060)

    conf = pg.confirm('ส่งข้อความสำเร็จ! \nคุณต้องการเริ่มโปรแกรมใหม่ใช่หรือไม่ ?',buttons=['เริ่มใหม่','ยกเลิก'])
    restart() if conf == 'เริ่มใหม่' else exit()

start = pg.prompt("มือที่ต้องการจองเริ่ม", "Bot Message", "")
stop = pg.prompt("มือที่ต้องการจองสิ้นสุด", "Bot Message", "")

btn = pg.confirm(text='กดปุ่ม ส่ง เพื่อเริ่มทำงาน', title='Bot Message', buttons=['ส่ง','กำหนดเวลา','ส่งแบบหลายมือ','ยกเลิก'])

if btn == 'ส่ง':
    number()
elif btn == 'กำหนดเวลา':
    timeSet = pg.prompt(text='กำหนดเวลาในการส่งข้อความ ตัวอย่าง 21:00:59', title='กำหนดเวลา' , default='')
    while True:
        tz_Bangkok = pytz.timezone('Asia/Bangkok')
        datetime_Bangkok = datetime.now(tz_Bangkok)
        # print("Bangkok time:", datetime_Bangkok.strftime("%H:%M:%S"))
        if datetime_Bangkok.strftime("%H:%M:%S") == timeSet:
            number()
elif btn == 'ส่งแบบหลายมือ':
    timeSet = pg.prompt(text='กำหนดเวลาในการส่งข้อความ ตัวอย่าง 21:00:59', title='กำหนดเวลา' , default='')
    while True:
        tz_Bangkok = pytz.timezone('Asia/Bangkok')
        datetime_Bangkok = datetime.now(tz_Bangkok)
        # print("Bangkok time:", datetime_Bangkok.strftime("%H:%M:%S"))
        if datetime_Bangkok.strftime("%H:%M:%S") == timeSet:
            setRange()
else:
    exit()