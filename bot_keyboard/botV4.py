from pynput.keyboard import Key, Controller
import schedule
import pymsgbox
import sys
import os
import time
import pyautogui as pg

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

# ----------------------------------------------- 

def number():
    #facebook ????????????????????? 1 ????????? ???????????? 00:00:59
    num10()

    for i in range(int(stop),int(start) - 1, int(-1)):
        method = eval("num"+str(i))
        method()

    conf = pg.confirm('????????????????????????????????????????????????! \n???????????????????????????????????????????????????????????????????????????????????????????????????????????? ?',buttons=['???????????????????????????','??????????????????'])
    restart() if conf == '???????????????????????????' else exit()

start = pg.prompt("???????????????????????????????????????????????????????????????", "Bot Message", "")
stop = pg.prompt("?????????????????????????????????????????????????????????????????????", "Bot Message", "")

btn = pg.confirm(text='?????????????????? ????????? ?????????????????????????????????????????????', title='Bot Message', buttons=['?????????','???????????????????????????','??????????????????'])

if btn == '?????????':
    number()
elif btn == '???????????????????????????':
    time = pg.prompt(text='???????????????????????????????????????????????????????????????????????? ???????????????????????? 21:00:59', title='???????????????????????????' , default='')

    schedule.every().day.at(time).do(number)
    while True:
        schedule.run_pending()
else:
    exit()