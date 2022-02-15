import socket

def mainRun() :
    # host = "127.0.0.1" #IP
    host = 'localhost'
    port= 4000
    server = socket.socket() #socket เปรียบเหมือน link ในการติดต่อสื่อสารกับเครื่อง client
    server.setsockopt(socket.SOL_SOCKET, socket.SO_REUSEADDR, 1) #set option ของ socket ทำให้ socket สามารถใช้ port เดียวกันได้
    server.connect((host,port)) #เชื่อมต่อ server
    data = input("Input data from server : ")
        
    #กระบวนรับส่งข้อมูลเครื่อง client เข้ามาที่เครื่อง server ระหว่างทางจะส่งข้อมูลเป็นแบบ byte
    while data != 'q' : 
        server.send(data.encode('utf-8')) #เข้ารหัสข้อมูลที่จะส่งออกไปเป็น byte
        data = server.recv(1024).decode('utf-8') #รับข้อมูลจาก server 1024 bit = 1 byte แปลงเป็น String
        print("Data From Server :"+data)
        data = input("Input dat from server : ")
    server.close()

if __name__ == "__main__": #เช็ค name ว่าเป็น main หลักไหมถ้าเป็นให้ทำงาน function mainRun
    mainRun()