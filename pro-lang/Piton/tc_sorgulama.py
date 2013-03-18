#!-*- coding:utf-8 -*-

def tc_sorgulama(tc):
	tc = str(tc)
	if type(tc) != str or len(tc) != 11 or tc < 0:
		print "Lütfen 11 basamaklı bir tamsayı giriniz"
	else:	
		tc_list = list(str(tc))
		tek ,cift = 0, 0
		for indeks in range(0, len(tc_list) - 2):
			if indeks % 2 == 0:
				tek += int(tc_list[indeks])
			else:
				cift += int(tc_list[indeks])			 
		hesap = (tek * 7 - cift) % 10
		hesap2 = (tek + cift + int(tc_list[9])) % 10  
		if int(tc_list[9]) == hesap and int(tc_list[10]) == hesap2:
			print "TC Kimlik numarası geçerlidir"
		else:
			print "TC Kimlik numarası geçerli değildir"
