###########################################################
#
#  Name:                 Joseph Markley
#  Assignment:           Rock Paper Scissors
#  Date:                 01/29/2019
#  Class:                CIS 282
#  Description:          Rock Paper Scissors Game
#
###########################################################

# Introduce the user to the rock paper scissors game.
# explain the game if they don't want to play then display the win's / losses and draws
# if they decide to play then proceed with the game.
# computer will choose one of the three options prompt user for a choice to select one of the three options
# make those options number choices only. 1. Rock etc.
# if a user inputs a number that is invalid or letters etc. prompt user to input the correct number for what is shown.
# Once chosen the application will reveal the choices and print a statement showing who won, lost or if a draw occurred.

print "Welcome to the Rock, Paper, Scissors game! It's pretty simple, you just pick one of the following
choices (rock, paper, scissors) and if you win, lose or draw I will display a message! "
puts
print "Would you like to play?(Y for yes N for no): "
user_play = gets.chomp.upcase

rock = 1
paper = 2
scissors = 3
score_tie = 0
user_wins = 0
computer_wins = 0

# Note: I was attempting to make it so a user cannot make an error, at all. I tried nested loops didn't work.
# while user_play != "Y"
#   print "Did you mean to end the game? Press Y to play or N to not play: "
#   user_play = gets.chomp.upcase
# end

  while user_play == "Y"
    puts "Please select one of the following numbers as your choice:
1. Rock
2. Paper
3. Scissors
Your number here: "
    user_selected = gets.to_i
    computer_number = rand(1..3)
    # puts "computer chose: #{computer_number}"

    if user_selected == rock && computer_number == paper
      computer_wins += 1
      puts "The Computer wins!: #{computer_wins}"

    elsif user_selected == paper && computer_number == scissors
      computer_wins += 1
      puts "The Computer wins!: #{computer_wins}"

    elsif user_selected == scissors && computer_number == rock
      computer_wins += 1
      puts "The Computer wins!: #{computer_wins}"

    elsif user_selected == paper && computer_number == rock
      user_wins += 1
      puts "You won!: #{user_wins}"

    elsif user_selected == rock && computer_number == scissors
      user_wins += 1
      puts "You won!: #{user_wins}"

    elsif user_selected == scissors && computer_number == paper
      user_wins += 1
      puts "You won!: #{user_wins}"

    else
      user_selected == computer_number
      score_tie += 1
      puts "Wow a tie!: #{score_tie}"

    end
    print "Would you like to continue?(Y for yes N for no): "
    user_play = gets.chomp.upcase
  end
puts "Your wins: #{user_wins}"
puts "Computer wins: #{computer_wins}"
puts "The amount of ties: #{score_tie}"