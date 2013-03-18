#-*- coding:utf-8 -*-

def sayac(dosya_adi):
	bs, hs, ss = 0, 0, -1
	foo = open(dosya_adi)
	for i in foo:
		for j in i:
			hs += 1
			if j == ' ':
				bs += 1
			if j == '\n':
				ss += 1
			if ss == -1:
				ss = 0
	print "harf sayisi = ", hs - bs - ss
	print "bosluk sayisi = ", bs
	print "satir sayisi = ", ss 			

		 
	
	
