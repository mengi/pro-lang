# -*- coding: utf-8 -*-

def liste_topla(liste):
	toplam = 0
	ek_liste = []
	for i in liste:
		if type(i) == list:
			ek_liste.append(i)
	
	sonuc = []
	for index, deger in enumerate(ek_liste):
		for rakam in deger:
			toplam += rakam
		sonuc.append(toplam)	 
		toplam = 0
	
	print ek_liste[index], "toplam = ", sonuc[index]
