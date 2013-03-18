import Image
#-*- coding:utf-8 -*-

#kuyruğun başı = listenin ilk elemanı
class Queue:
	
	def __init__(self):
		self.items = []
		
	#kuyruk boș mu? Mantıksal değer
	def isEmpty(self):
		return self.items == []
		
	#kuyruğun sonuna item’ı ekle
	def enqueue(self, item):
		self.items.append(item)
		
	#kuyruğun bașındaki öğeyi çıkar, geri döndür, kuyruk güncellenir
	def dequeue(self):
		return self.items.pop(0)
	
	#kuyrukta kaç öğe var? Tamsayı değer
	def size(self):
		return len(self.items)	
		
def fill(a, b):
    I = Image.open("foo.png")
    S = []
    q = Queue()
    renk = I.getpixel((a, b))
    q.enqueue([a, b])

    while (q.size() >= 1):
        P = q.dequeue()
        x, y = P
        if (I.getpixel((x, y)) == renk):
            if ([x, y] not in S):
                S.append([x, y])
                if (x - 1 > 0):
                    if ([x - 1, y] not in S and I.getpixel((x - 1, y)) == renk):
                        q.enqueue([x - 1, y])
		    if (y + 1 < I.size[1]):
			if ([x - 1, y + 1] not in S and I.getpixel((x - 1, y + 1)) == renk):
			    q.enqueue([x - 1, y + 1])
                    if (y - 1 > 0):
                        if ([x - 1, y - 1] not in S and I.getpixel((x - 1, y - 1)) == renk):
                            q.enqueue([x - 1, y - 1])
                        

                if (y > 0) :
                    if ([x, y - 1] not in S and I.getpixel((x, y - 1)) == renk):
						q.enqueue([x, y - 1])
                if (y + 1 < I.size[1]):
                    if ([x, y + 1] not in S and I.getpixel((x, y + 1)) == renk):
                        q.enqueue([x, y + 1] )
                        
                if (x + 1 < I.size[0]):
                    if ([x + 1, y] not in S and I.getpixel((x + 1, y)) == renk) :
                        q.enqueue([x + 1, y])
                    if (y + 1 < I.size[1]):
                        if ([x + 1, y + 1] not in S and I.getpixel((x + 1, y + 1)) == renk):
                            q.enqueue([x + 1, y + 1])
                    if (y > 0):
                       if ([x + 1,y - 1] not in S and I.getpixel((x + 1, y - 1)) == renk):
                            q.enqueue([x + 1, y - 1])
                    
    while (len(S) > 0):
        elemanimiz = S.pop()
        I.putpixel((elemanimiz[0], elemanimiz[1]), (0, 255, 0, 0))
    I.save("Sonuc.png")
    I.show()
fill(50,50)
