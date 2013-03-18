 #-*- coding:utf-8 -*-
 
class Question:
	
	def __init__(self):
		self.soru_giriniz = raw_input("Soru Cümlesi :")
		
class Selection(Question):
	
	def __init__(self):
		Question.__init__(self)
		self.dgr_cvp = None
		
	def selections(self):
		self.cevaplar = []
		self.items = []
		self.secenekler = []
		
		self.secenek1 = raw_input("Secenek1 giriniz :")
		self.items.append(self.secenek1)
		cevap = raw_input("Doğru mu? (E/H) :")
		if cevap in "EeHh":
			self.secenekler.append("A")
			self.cevaplar.append(cevap)
		
		self.secenek2 = raw_input("Secenek2 giriniz :")
		self.items.append(self.secenek2)
		cevap = raw_input("Doğru mu? (E/H) :")
		if cevap in "EeHh":
			self.secenekler.append("B")
			self.cevaplar.append(cevap)
		
		self.secenek3 = raw_input("Secenek3 giriniz :")
		self.items.append(self.secenek3)
		cevap = raw_input("Doğru mu? (E/H) :")
		if cevap in "EeHh":
			self.secenekler.append("C")
			self.cevaplar.append(cevap)
	
		self.secenek4 = raw_input("Secenek4 giriniz :")
		self.items.append(self.secenek4)
		cevap = raw_input("Doğru mu? (E/H) :")
		if cevap in "EeHh":
			self.secenekler.append("D")
			self.cevaplar.append(cevap)
	
		self.secenek5 = raw_input("Secenek5 giriniz :")
		self.items.append(self.secenek5)
		cevap = raw_input("Doğru mu? (E/H) :")
		if cevap in"EeHh":
			self.secenekler.append("E")
			self.cevaplar.append(cevap)
			
			
class Dogru(Selection):
	def __init__(self):
		self.selections()
		
	def kontrol(self):
		self.cevaptut = []
		self.sonuctut = []
		
		for i in range(0,len(self.items)):
			if self.cevaplar[i] in "Ee":

				self.cevaptut.append(self.secenekler[i])
		
		for j in range(0, len(self.cevaptut)):
			yanit = raw_input("Cevabiniz (A..E):")
			self.sonuctut.append(yanit)
			self.sonuctut.sort()
		 
		dogru = True
		for k in range(0,len(self.cevaptut)):
			if self.cevaptut[k] != self.sonuctut[k]:
				dogru = False
		
		if dogru == False:
			if len(self.cevaptut) == 1:
				print "Yanitiniz-", yanit, ",", "Dogrusu-", self.cevaptut[0]
			else:
				print "Bilemediniz!"
				for m in range(0, len(self.cevaptut)):
					print "yanitlar", self.sonuctut[m], ",", "Dogrusu-", self.cevaptut[m]
			print "Puan: 0"
			
		else:
			print "Tebrikler Bildiniz! Puan: 1" 
		
class QestionCTS(Selection, Dogru):
	
	def __init__(self):
		Selection.__init__(self)
		self.selections()
	
	def sor(self):
		print self.soru_giriniz
		print "A )", self.items[0]
		print "B )", self.items[1]
		print "C )", self.items[2]
		print "D )", self.items[3]
		print "E )", self.items[4]
		self.kontrol()
s1=QestionCTS()
s1.sor()

