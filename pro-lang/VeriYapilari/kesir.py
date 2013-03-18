#-*- coding:utf-8 -*-
class Kesir:
	def __init__(self, payim, paydam):
		self.pay = payim
		self.payda = paydam
	
	def __str__(self):
		
		return str(self.pay) + "/"+ str(self.payda)
		
	def show(self):
		
		print self.pay, "/", self.payda
	
	def __topla__(self, yeni):
		
		yeni_pay = self.pay * yeni.payda + self.payda * yeni.pay
		yeni_payda = self.payda * yeni.payda
		eb = ebob(yeni_pay,yeni_payda)
		return Kesir(yeni_pay / eb , yeni_payda / eb)
	
	def __cikarma__(self, yeni):
		
		yeni_pay = self.pay * yeni.payda - self.payda * yeni.pay
		yeni_payda = self.payda * yeni.payda
		eb = ebob(yeni_pay,yeni_payda)
		return Kesir(yeni_pay / eb, yeni_payda / eb)
	
	def __carpma__(self, yeni):
		
		yeni_pay = self.pay * yeni.pay
		yeni_payda = self.payda * yeni.payda
		eb = ebob(yeni_pay,yeni_payda)
		return Kesir(yeni_pay / eb, yeni_payda / eb)
	
	def __bolme__(self, yeni):
		
		yeni_pay = self.pay * yeni.payda
		yeni_payda = self.payda * yeni.pay
		eb = ebob(yeni_pay,yeni_payda)
		return Kesir(yeni_pay / eb, yeni_payda / eb)
	
def ebob(m,n):
	while m % n != 0:
		oldm = m
		oldn = n
			
		m = oldn
		n = oldm % oldn
	return n	 


f1 = Kesir(1,2)
f2 = Kesir(3,4)
f3 = f1.__topla__(f2)
f4 = f1.__cikarma__(f2)
f5 = f1.__carpma__(f2)
f6 = f1.__bolme__(f2)
f7 = f3.__topla__(f2)

