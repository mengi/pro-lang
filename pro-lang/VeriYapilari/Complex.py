class Complex:
	
	def __init__(self, reel, sanal):
		self.re = reel
		self.imj = sanal
	
	def __str__(self):
		if self.re == 0:
			return str(self.imj) + "i"
		elif self.imj == 0:
			return str(self.re)
		else:
			return str(self.re) + "+" + str(self.imj) + "i"
	
	def show(self):
		print self.re, "+", self.sa, "i"
	
	def __toplam__(self, yeni):
		yeni_re = self.re + yeni.re
		yeni_imj = self.imj + yeni.imj
		return Complex(yeni_re, yeni_imj)
	
	def __cikarma__(self, yeni):
		yeni_re = self.re - yeni.re
		yeni_imj = self.imj - yeni.imj
		return Complex(yeni_re, yeni_imj)
	
	def __carpma__(self, yeni):
		if type(yeni) == int or type(yeni) == float:
			return Complex(self.re * yeni, self.imj * yeni)
		yeni_re = self.re * yeni.re + (-1) * self.imj * yeni.imj
		yeni_imj = self.re * yeni.imj + self.imj * yeni.re
		return Complex(yeni_re, yeni_imj)
	
	def __mutlak__(self, yeni):
		if type(yeni) == int or type(yeni) == float:
			return ((self.re - yeni) ** 2 + (self.imj) ** 2 ) ** 0.2
		return ((self.re - yeni.re) ** 2 + (self.imj - yeni.imj) ** 2) ** 0.2
	
	def __bolme__(self, yeni):
		payda = float((self.re ** 2) - (self.imj ** 2) * (-1))
		yeni_re = self.re * yeni.re + self.imj * yeni.imj
		yeni_imj = self.re * yeni.imj - self.imj * yeni.re 
		return Complex(yeni_re / payda, yeni_imj / payda)
f1 = Complex(1,2) 
f2 = Complex(1,0)
f3 = f1.__toplam__(f2)
f4 = f1.__cikarma__(f2)
f5 = f1.__carpma__(f2)
f6 = f1.__mutlak__(f2)
f7 = f1.__bolme__(f2)
print f3, f4 , f5, f6, f7
