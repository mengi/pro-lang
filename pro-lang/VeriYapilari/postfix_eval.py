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

def postfix_eval(girdi):
	s = Stack()
	
	for rakam in girdi:
		if rakam in "0123456789":
			s.push(int(rakam))
		else:
			rakam2 = s.pop()
			rakam1 = s.pop()
			islem = sonuc(rakam, rakam1, rakam2)
			s.push(islem)
	return s.pop()

def sonuc(isaret, sayi1, sayi2):
	if isaret == "*":
		return sayi1 * sayi2
	else:
		if isaret == "/":
			return sayi1 / sayi2
		else:
			if isaret == "-":
				return sayi1 - sayi2
			else:
				return sayi1 + sayi2
print postfix_eval("56+7*")
