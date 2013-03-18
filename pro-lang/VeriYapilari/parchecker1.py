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
		
def parchecker(sembller):
	s = Stack() 
	index = 0
	durum = True
	while index <= len(sembller) - 1 and durum:
		smb = sembller[index]
		if smb in "({[":
			s.push(smb)
		else:
			if s.isEmpty():
				durum = False
			else:
				karsilastir = s.pop()
				if not kontrol(karsilastir, smb):
					durum = False
		index += 1
	if s.isEmpty() and durum:
		return durum
	else:
		return False

def kontrol(acil, kapan):
	acil = "({["
	kapan = ")}]"
	return acil.index(acil) == kapan.index(kapan)

