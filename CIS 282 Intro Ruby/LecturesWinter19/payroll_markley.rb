###########################################################
#
#  Name:                 Joseph Markley
#  Assignment:           Header
#  Date:                 01/24/2019
#  Class:                CIS 282
#  Description:          Creating a payroll application
#
###########################################################

# Get user input and store that value
# store the information for later calculations.
# output what the user has entered

# input from the user
puts "Please enter your full name: "
full_name = gets.chomp

puts "Please enter the number of hours you have worked: "
hours_worked = gets.to_f

puts "Please enter your hourly pay rate: "
hourly_pay = gets.to_f

puts "Enter federal tax withholding rate: "
federal_rate = gets.to_f

puts "Enter the State tax withholding rate: "
state_tax = gets.to_f

#Output from the users input.

puts "Employee Name: #{full_name}"

puts "Hours Worked: #{hours_worked}"

puts "Pay Rate: $#{hourly_pay}"

#calculations / formatting
gross = hourly_pay * hours_worked
puts "Gross Pay: $#{format("%.2f", gross)}"

if federal_rate < 1
  federal_rates = federal_rate * 100
else
  federal_rates = federal_rate
end

if state_tax < 1
  state_taxes = state_tax * 100
else
  state_taxes = state_tax
end

if federal_rate < 1
  federal_rate = gross * federal_rate
else
  federal_rate = gross * (federal_rate / 100)
end

if state_tax < 1
  state_tax = gross * state_tax
else
  state_tax = gross * (state_tax / 100)
end

total_deduction = federal_rate + state_tax

net_pay = gross - total_deduction

#output from calculations
puts "Deductions:"
puts "\tFederal Withholding(#{format("%.2f", federal_rates)}%): $#{format("%.2f", federal_rate)}"
puts "\tState Withholding(#{format("%.2f", state_taxes)}%): $#{format("%.2f", state_tax)}"
puts "\tTotal Deductions: $#{format("%.2f", total_deduction)}"
puts "Net Pay: $#{format("%.2f", net_pay)}"