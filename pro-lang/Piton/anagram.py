#!-*- coding:utf-8- -*-

def anagram(s1,s2):
	c1 = [0] * 26
	c2 = [0] * 26
	
	for i in range(0,len(s1)):
		pos1 = ord(i)- ord('a')
		c1[pos1] += 1
	
	for i in range(0,len(s2)):
		pos2 = ord(i)- ord('a')
		c2[pos2] += 1
	
	durum = True
	indeks = 0
	while indeks < 26  and durum:
		if c1[indeks] == c2[indeks]:
			indeks += 1
		else:
			durum = False
	print durum		 	 	
	
	
anagram("heart", "earth")	
