#!-*- coding:utf-8 -*-

class Stack:
	def __init__(self, sayi = 2):
		self.n = sayi
		self.items = []
	def isEmpty(self):
		return self.items == []	
	def push(self, item):
		if self.size() < self.n:
			self.items.append(item)
		else:
			return "Yigit dolu %s eklenemedi" %(item)
	def pop(self):
		if not s.isEmpty():
			return self.items.pop()
		else:
			print "Yigit boş"
	def peek(self):
		return self.items[len(self.items)-1]
	def size(self):
		if not s.isEmpty():
			return len(self.items)
		else:
			print "Yigit bos"

s = Stack()
s.push("a")

s.size()
