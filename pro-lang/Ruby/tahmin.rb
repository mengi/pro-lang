
words = ['kestane', 'gurgen', 'palamut', 'elma', 'armut', 'enginar']
secret = words[rand(words.length)]

print "tahmin et? "
while guess = STDIN.gets
  guess.chop!
  if guess == secret
    print "Bildin!\n"
    break
  else
    print "Üzgünüm kaybettin.\n"
  end
  print "tahmin et? "
end
print "Kelime ", secret, ".\n"
