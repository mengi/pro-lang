#!-*- coding:utf-8 -*-
import csv

people = csv.reader(open('ogrenci_listesi1.csv'))
hash_people = {}

for k in range(0, 64):
	hash_people[k] = 0

for row in people:
	first_name, last_name = row[0], row[1]
	sum1, sum2 = 0, 0
	
	for chr in first_name:
		sum1 += (33 ^ (52 * ord(chr)))
	
	for chr in last_name:
		sum2 += (31 * 37 ^ ord(chr))
	
	sum_all = (sum1 + sum2) % 64
	
	if sum_all in hash_people.keys():
		hash_people[sum_all] += 1
	else:
		hash_people[sum_all] = 1

clash = 0
for k in hash_people.keys():
	if hash_people[k] < 1:
		clash += 1

non_clash = len(hash_people) - clash

print "Cakismayanlarin sayisi : ", non_clash 		
print "Cakisanlarin sayisi :", clash
print "Basari durumu = ", ((non_clash * 1.0) / len(hash_people))

