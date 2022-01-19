import pyautogui as pg
import schedule
import time
import pymsgbox
import sys
import os

pymsgbox.rootWindowPosition = "+0+0"

def restart():
    print("argv was",sys.argv)
    print("sys.executable was", sys.executable)
    print("restart now")

    os.execv(sys.executable, ['python'] + sys.argv)
  
def number():
    #facebook ส่งก่อน 3 ตัว เวลา 00:00:01
    #line ส่งก่อน 5 ตัว เวลา 00:00:02
    pg.write('10')
    pg.press('enter')
    pg.write('11')
    pg.press('enter')
    pg.write('12')
    pg.press('enter')
    pg.write('13')
    pg.press('enter')
    pg.write('14')
    pg.press('enter')
    buffer = ''
    for i in range(int(start),int(stop) + 1, int(book)):
        buffer = ''
        for j in range(int(book)):
            if i+j !=  int(stop)+1:
                buffer = buffer + ' ' + str(i+j)
        pg.write(buffer)
        pg.press('enter')

    conf = pg.confirm('ส่งข้อความสำเร็จ! \nคุณต้องการเริ่มโปรแกรมใหม่ใช่หรือไม่ ?',buttons=['เริ่มใหม่','ยกเลิก'])
    restart() if conf == 'เริ่มใหม่' else exit()


start = pg.prompt("มือที่ต้องการจองเริ่ม", "Bot Message", "")
stop = pg.prompt("มือที่ต้องการจองสิ้นสุด", "Bot Message", "")
book = pg.prompt("จองทีละกี่มือ", "Bot Message", "1")

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

# time.sleep(1)