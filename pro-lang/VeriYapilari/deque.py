#-*- coding:utf-8 -*-
class Dequeue():
	def __init__(self):
		self.items = []
	
	def isEmpty():
		return self.items == []
	
	def ekleon(self, item):
		self.items.insert(0,item)
	
	def eklearka(self, item):
		self.items.append(item)
	
	def silon(self):
		return self.items.pop(0)
	
	def silarka(self):
		return self.items.pop()
	
	def size(self):
		return len(self.items)

def palidrom(string):
	durum = True
	d = Dequeue()
	for harf in string:
		d.ekleon(harf)
	
	while d.size() > 1 and durum:
		bas = d.silon()
		arka = d.silarka()
		if bas != arka:
			durum = False
	return durum 

print palidrom("radar")
