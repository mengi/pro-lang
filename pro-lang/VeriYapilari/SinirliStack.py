#-*- coding:utf-8 -*-

class Stack():
	
	def __init__ (self, sayi = 3):
		self.items = []
		self.n = sayi 
	
	def isEmpty(self):
		return self.items == []
	
	def push(self,item):
		if len(self.items) != self.n:
			self.items.append(item)
		else:
			print "Yigit dolu %s eleman eklenemedi" %(item)
	
	def pop(self):
		if not s.isEmpty():
			return self.items.pop()
		print "Bos yıgıt"
	
	def peek(self):
		if not s.isEmpty():
			return self.items[len(self.items - 1)]
		print "Bos Yıgıt"

	def size(self):
		return len(self.items)



