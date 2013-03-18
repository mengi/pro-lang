#-*- coding:utf-8 -*-

class Stack():
	def __init__(self):
		self.items = []
	
	def isEmpty(self):
		return self.items == []
	
	def push(self, item):
		self.items.append(item)
	
	def pop(self):
		return self.items.pop()
	
	def peek(self):
		return self.items[len(self.items - 1)]
	
	def size(self):
		return len(selm.items)

def parChecker(smbler):
	s = Stack()
	indeks = 0
	durum = True
	while indeks <= len(smbler) - 1  and durum:
		smbl = smbler[indeks]
		if smbl == '(':
			s.push(smbl)
		else:
			if s.isEmpty():
				durum = False
			else:
				s.pop()
		indeks += 1
	if s.isEmpty() and durum :
		return durum 
	else:
		return False
print parChecker("()()()()()") 
	
