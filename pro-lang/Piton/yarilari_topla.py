#!-*- coding:utf-8 -*-

def yarilari_topla(sayi):
	toplam = 0
	sayac = 0
	if type(sayi) == int:
		if sayi == 0:
			print "lütfen bir tamsayi giriniz"
		elif sayi < 0:
			print "lütfen bir tamsayi giriniz"
		elif sayi > 0:
			x = sayi
			while sayi >= 0.1 and sayac != x:
				sayi /= 2.0
				toplam += sayi
				sayac += 1
			print toplam		
	elif type(sayi) == float:
		print "lütfen bir tamsayi giriniz"
