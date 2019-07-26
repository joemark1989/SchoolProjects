def acronym(words)
  return_string = ""
  split_words = words.split(" ")
  split_words.each do |word|
    return_string += word.chr.capitalize!
  end
  return return_string
end

puts acronym("hello there")
