#-*- codig:utf-8 -*-

class Deque():
	def __init__(self):
		self.items = []
	
	def isEmpty(self):
		return self.items == []
	
	def enqueue(self, item):
		self.items.insert(0, item)
	
	def dequeue(self):
		return self.items.pop()
	
	def size(self):
		return len(self.items)

def hot(isimler, sira):
	d = Deque()
	
	for isim in isimler:
		d.enqueue(isim)
	
	while d.size() > 1:
		for i in range(sira):
			d.enqueue(d.dequeue())
		
		d.dequeue()
	
	return d.dequeue()

isim = ["ali","memet","lale","hale","jale"]
sira = 5
print hot(isim, sira) 
