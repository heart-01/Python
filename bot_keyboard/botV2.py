from pynput.keyboard import Key, Controller
import schedule
import pymsgbox
import sys
import os
import pyautogui as pg

pymsgbox.rootWindowPosition = "+0+0"

keyboard = Controller()

def num1():
    keyboard.press("1")
    keyboard.release("1")

def num2():
    keyboard.press("2")
    keyboard.release("2")

def num3():
    keyboard.press("3")
    keyboard.release("3")

def num4():
    keyboard.press("4")
    keyboard.release("4")

def num5():
    keyboard.press("5")
    keyboard.release("5")

def num6():
    keyboard.press("6")
    keyboard.release("6")

def num7():
    keyboard.press("7")
    keyboard.release("7")

def num8():
    keyboard.press("8")
    keyboard.release("8")

def num9():
    keyboard.press("9")
    keyboard.release("9")

def num0():
    keyboard.press("0")
    keyboard.release("0")

def num10():
    keyboard.press("1")
    keyboard.release("1")
    keyboard.press("0")
    keyboard.release("0")

def num11():
    keyboard.press("1")
    keyboard.release("1")
    keyboard.press("1")
    keyboard.release("1")

def num12():
    keyboard.press("1")
    keyboard.release("1")
    keyboard.press("2")
    keyboard.release("2")

def num13():
    keyboard.press("1")
    keyboard.release("1")
    keyboard.press("3")
    keyboard.release("3")

def num14():
    keyboard.press("1")
    keyboard.release("1")
    keyboard.press("4")
    keyboard.release("4")

def num15():
    keyboard.press("1")
    keyboard.release("1")
    keyboard.press("5")
    keyboard.release("5")

def num16():
    keyboard.press("1")
    keyboard.release("1")
    keyboard.press("6")
    keyboard.release("6")

def num17():
    keyboard.press("1")
    keyboard.release("1")
    keyboard.press("7")
    keyboard.release("7")

def num18():
    keyboard.press("1")
    keyboard.release("1")
    keyboard.press("8")
    keyboard.release("8")

def num19():
    keyboard.press("1")
    keyboard.release("1")
    keyboard.press("9")
    keyboard.release("9")

def num20():
    keyboard.press("2")
    keyboard.release("2")
    keyboard.press("0")
    keyboard.release("0")

def num21():
    keyboard.press("2")
    keyboard.release("2")
    keyboard.press("1")
    keyboard.release("1")

def num22():
    keyboard.press("2")
    keyboard.release("2")
    keyboard.press("2")
    keyboard.release("2")

def num23():
    keyboard.press("2")
    keyboard.release("2")
    keyboard.press("3")
    keyboard.release("3")

def num24():
    keyboard.press("2")
    keyboard.release("2")
    keyboard.press("4")
    keyboard.release("4")

def num25():
    keyboard.press("2")
    keyboard.release("2")
    keyboard.press("5")
    keyboard.release("5")

def num26():
    keyboard.press("2")
    keyboard.release("2")
    keyboard.press("6")
    keyboard.release("6")

def num27():
    keyboard.press("2")
    keyboard.release("2")
    keyboard.press("7")
    keyboard.release("7")

def num28():
    keyboard.press("2")
    keyboard.release("2")
    keyboard.press("8")
    keyboard.release("8")

def num29():
    keyboard.press("2")
    keyboard.release("2")
    keyboard.press("9")
    keyboard.release("9")

def num30():
    keyboard.press("3")
    keyboard.release("3")
    keyboard.press("0")
    keyboard.release("0")

def num31():
    keyboard.press("3")
    keyboard.release("3")
    keyboard.press("1")
    keyboard.release("1")

def num32():
    keyboard.press("3")
    keyboard.release("3")
    keyboard.press("2")
    keyboard.release("2")

def num33():
    keyboard.press("3")
    keyboard.release("3")
    keyboard.press("3")
    keyboard.release("3")

def num34():
    keyboard.press("3")
    keyboard.release("3")
    keyboard.press("4")
    keyboard.release("4")

def num35():
    keyboard.press("3")
    keyboard.release("3")
    keyboard.press("5")
    keyboard.release("5")

def num36():
    keyboard.press("3")
    keyboard.release("3")
    keyboard.press("6")
    keyboard.release("6")

def num37():
    keyboard.press("3")
    keyboard.release("3")
    keyboard.press("7")
    keyboard.release("7")

def num38():
    keyboard.press("3")
    keyboard.release("3")
    keyboard.press("8")
    keyboard.release("8")

def num39():
    keyboard.press("3")
    keyboard.release("3")
    keyboard.press("9")
    keyboard.release("9")

def num40():
    keyboard.press("4")
    keyboard.release("4")
    keyboard.press("0")
    keyboard.release("0")

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
    #line ส่งก่อน 8 ตัว เวลา 00:00:02 เลข 2 ตัวส่งไปก่อน 4 ตัว
    #facebook ส่งก่อน 3 ตัว เวลา 00:00:01
    num10()
    enter()
    num11()
    enter()
    num12()
    enter()
    # num13()
    # enter()
    # num7()
    # enter()
    for i in range(int(start),int(stop) + 1, int(1)):
        method = eval("num"+str(i))
        method()
        enter()

    conf = pg.confirm('ส่งข้อความสำเร็จ! \nคุณต้องการเริ่มโปรแกรมใหม่ใช่หรือไม่ ?',buttons=['เริ่มใหม่','ยกเลิก'])
    restart() if conf == 'เริ่มใหม่' else exit()

start = pg.prompt("มือที่ต้องการจองเริ่ม", "Bot Message", "")
stop = pg.prompt("มือที่ต้องการจองสิ้นสุด", "Bot Message", "")

btn = pg.confirm(text='กดปุ่ม ส่ง เพื่อเริ่มทำงาน', title='Bot Message', buttons=['ส่ง','กำหนดเวลา','ยกเลิก'])

if btn == 'ส่ง':
    number()
elif btn == 'กำหนดเวลา':
    time = pg.prompt(text='กำหนดเวลาในการส่งข้อความ ตัวอย่าง 21:00:59', title='กำหนดเวลา' , default='')

    schedule.every().day.at(time).do(number)
    while True:
        schedule.run_pending()
else:
    exit()