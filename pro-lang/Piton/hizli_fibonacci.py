#!-*- coding:utf-8 -*-


def hizli_fibonacci(sayi):
	sayilar = {0 : 0, 1 : 1, 2 : 1, 3 : 2, 4 : 3, 5 : 5, 6 : 8, 7 : 13, 8 : 21, 9 : 34, 10 : 55}
	if type(sayi) == float:
		return "Lutfen pozitif bir tamsayi giriniz."
	elif sayi < 0:
		return "Lutfen pozitif bir tamsayi giriniz."
	else:
		if 0 <= sayi and sayi <= 10:
			return sayilar.get(sayi)
		else:
			return hizli_fibonacci(sayi - 1) + hizli_fibonacci(sayi - 2)
