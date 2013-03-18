#!-*- coding:utf-8 -*-

def basamak_sayisi(sayi):
	toplam = 0
	while sayi > 0:
		toplam += 1
		sayi /= 10 
	print "basamak sayisi = ", toplam
