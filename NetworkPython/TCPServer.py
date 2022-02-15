import socket

def mainRun() :
    # host = "127.0.0.1" #IP
    host = 'localhost'
    port= 5000
    server = socket.socket() #socket เปรียบเหมือน link ในการติดต่อสื่อสารกับเครื่อง client
    server.setsockopt(socket.SOL_SOCKET, socket.SO_REUSEADDR, 1) #set option ของ socket ทำให้ socket สามารถใช้ port เดียวกันได้
    server.bind((host, port)) #ผูกค่า socket กับ host , port
    server.listen(5) #กำหนดจำนวน client ที่สามารถใช้งานร่วมกันได้
    print("Wating for client...")

    client,address = server.accept() #เป็นการยืนยันว่ามีเครื่อง client เชื่อมต่อเข้ามาแล้ว
    print("Connect From :"+str(address)) #แสดงข้อมูล address เครื่อง client ที่เชื่อมต่อเข้ามา
    
    #กระบวนรับส่งข้อมูลเครื่อง client เข้ามาที่เครื่อง server ระหว่างทางจะส่งข้อมูลเป็นแบบ byte
    while 1 : 
        data = client.recv(1024).decode('utf-8') #รับข้อมูลจาก client 1024 bit = 1 byte แปลงเป็น String
        if not data : #ถ้าไม่มี data
            break #หยุดการทำงาน

        print("Message From Client :"+data) #แสดงข้อความที่ client ส่งเข้ามา
        #ส่งข้อมูลกลับไปที่ Client โดยการแปลงข้อความเป็นตัวอักษรพิมพ์ใหญ่
        data = str(data.upper()) 
        client.send(data.encode('utf-8')) #เข้ารหัสข้อมูลที่จะส่งออกไปเป็น byte

    client.close() #ปิดการเชื่อมต่อที่ร้องขอ

if __name__ == "__main__": #เช็ค name ว่าเป็น main หลักไหมถ้าเป็นให้ทำงาน function mainRun
    mainRun()