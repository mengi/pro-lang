#-*- coding:utf-8 -*-

class Stack():
	def __init__(self):
		self.items = []
	
	def isEmpty(self):
		return self.items == []
	
	def push(self,item):
		self.items.append(item)
	
	def pop(self):
		return self.items.pop()
		
	def peek(self):
		return self.items[len(self.items) - 1]
	
	def size(self):
		return len(self.items)

def taban_cevir(n, taban):
	
	sayilar = "0123456789ABCDEF"
	s = Stack()
	
	while 0 < n:
		kalan = n % taban
		s.push(kalan)
		n = n / taban
	
	yeni = ""
	while not s.isEmpty():
		yeni += sayilar[s.pop()]
	
	return yeni

print taban_cevir(29,16)
