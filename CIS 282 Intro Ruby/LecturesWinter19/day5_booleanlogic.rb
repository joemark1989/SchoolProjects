#boolean logic
# conditional statements
#boolean: true or false
# if the light is red then stop
# if the light is red
#   stop
# end

#if statements
# if boolean_expression
#   code to run if boolean_expression is true
# end
# create the above English condition into code
# light = "red"
#
# if (light == "red")
#   puts "stop"
# end


# # c#
# if(boolean_expression){
# code to run if boolean_expression is true
#
# }
#

#if/else
# if boolean_expression
#   code to run if expression is true
# else
#   code to run if expression is false
# end

#example
# if light is red, stop else go
# light is yellow from above.
# if light == "red"
#   puts "stop"
# else
#   puts "go"
# end
#if/elseif

#example
# if light is red, stop.
# elseif light is yellow, proceed with caution
# else go
# at this point light is yellow from above
# light ="green"
#
# if light =="red"
#   puts "stop"
# elsif light =="yellow"
#        puts "proceed with caution"
#      else
#        puts "go"
# end
# with all boolean expressions
# we use comparision operators
# binary operators
# < <= > >= != == === !==

#logical operators
# && (and) || (or) !(not)

#truth tables
&& both statements have to be true
|| one statement has to be true

#compound boolean expression
# check if person is eligible to drive
# Washington state need to be 16 and need a license
age = 16
has_license = true
if age >= 16 && has_license == true
  puts "you can drive"
end
