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

def bace_to(n):
	s = Stack()
	while 0 < n:
		kalan = n % 2
		s.push(kalan)
		n = n / 2
	yeni = ""
	while not s.isEmpty():
		yeni = yeni + repr(s.pop())

	
	return int(yeni)

print bace_to(7)
