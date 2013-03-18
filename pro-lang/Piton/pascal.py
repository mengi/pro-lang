# -*- coding: utf-8 -*-

def faktoriyel(sayi):
	if sayi == 0 or sayi == 1:
		return 1
	else:
		return sayi * faktoriyel(sayi - 1)
		 

def pascal_ucgen_yap(boyut):
	liste = []
	n = boyut
	i , j =0 , 0
	while j <= i:
		a = faktoriyel(i) / (faktoriyel(i - j) * faktoriyel(j))
		liste.append(a)
		j += 1
		if j == i + 1:
			i += 1
			j = 0
			print " " * n, liste 
			n -= 1
			liste = []
		if i == boyut:
			break
