###########################################################
#
#  Name:                 Joseph Markley
#  Assignment:           Hash Assignment
#  Date:                 02/20/2019
#  Class:                CIS 282
#  Description:          A hash menu for a user to use for products.
#
###########################################################

# Step 1. Open the file labeled products.txt so that way we can gain access to it.
# Step 2. create your database that is linked to your products.txt ...
#         so that way you can manipulate the data first while the file is open ...
#         I need to get the hash value from the products.txt 123,234 etc and store that data into a hash.
#         Once the products.txt file has been modified close the file.                                    -- Completed
#   Step 3. Create a menu this menu will have 8 options as followed. View products, Add new products, Delete products
#   Delete products, view highest priced products, View lowest product, view the sum of all products, exit.
#   Those will be the options below will be a rough draft of how the items must look once it it outputted -- Completed
#   Item   Description      Price         Note: We will have to adjust the items within the array to fit this.
#   -----  --------------   ------                                                                       -- Completed
#        Step 4. Once the user has selected an option I will need to code for each option as it is different.
#        Starting with the first option. We need to view all products within the database{hash}
#        While user option is 1 we need to print out what is being stored in the database.
#        Note: Within the database there is two items to show. Adjust these items once they are outputted. -- Completed
#  Step 5. Add new product to the database we need to make sure they dont overwrite existing items.  --Not Complete
#  We will also need to have separate prompts for a user to input a description and price.           -- Complete
#    Step 6. Delete a product ID within the hash and give an error message if the product exist        -- Complete
#     Step 7. Display the database to the user so they can choose a product to update                    --Not Complete
#     If the user selects a product that doesn't exist in the database display message.
#     If the user chooses a product that does exist in the database we will need to create a new menu
#     for the user to choose from so they can update the item we need to have 3 separate
#     Selection's for the user 1. Update item description, 2. Update item Price, 3. Done updating.
#     Once the user is finished they are put back into the original menu so they can make selections.
#    Step 8. If the user wants to see the highest priced product we will need to grab the index
#    of the highest priced number and display that to the user.
#   Step. 9 If the user wants to see the lowest priced product we will need to grab the index
#   of the lowest priced number and display that to the user.
#     Step. 10 If the user wants to see the sum of all totals we need to add each index number
#     together and display that to the user.


products_file = File.open("products.txt")

database = {}
until products_file.eof?

  record = products_file.gets.chomp.split(",")
  # product_id = record[0].to_i
  # item = record[1]
  # price = record[2].to_f

  # Testing the differences between formatting record[2] and using to_i on record[2]
  # database[record[0].to_i] = [record[1], record[2].to_f]

  database[record[0].to_i] = [record[1], format("%.2f", record[2])]
end
products_file.close
# Note record[0] = the key, record[1] is the product record[2] is the price


menu_items = [
    "View all products",
    "Add a new product",
    "Delete a product",
    "Update a product",
    "View highest priced product",
    "View lowest priced product",
    "View total of all product prices",
]

def menu(menu)
  menu.each_with_index do |item, index|
    puts "#{index + 1}. #{item}"
  end
  puts "#{menu.length + 1}. Exit"
  puts
  print "please enter your choice: "
  user_choice = gets.to_i
  # returns user choice
  return user_choice
end

small_menu_items = [
    "Update item description",
    "Update item price",
]

def small_menu(small_menu)
  small_menu.each_with_index do |item, index|
    puts "#{index + 1}. #{item}"
  end
  puts "#{small_menu.length + 1}. Done updating."
  puts
  print "please enter your choice: "
  other_choice = gets.to_i
  # returns user choice
  return other_choice
end

# ****** NOTE I need to align the items better to accommodate for long descriptions and product id in ascending order.


while (user_choice = menu(menu_items)) != (menu_items.length + 1)
  if user_choice == 1
    puts "Item   Description       Price"
    puts "-----  --------------    ------"
    database.each do |record_id, item|
      product_id = record_id.to_s
      puts "#{product_id.ljust(6)} #{item[0].ljust(10)} #{item[1].rjust(13)}"
    end
  elsif user_choice == 2
    puts "Item   Description       Price"
    puts "-----  --------------    ------"
    database.each do |record_id, item|
      product_id = record_id.to_s
      puts "#{product_id.ljust(6)} #{item[0].ljust(10)} #{item[1].rjust(13)}"
    end
    # ********NOTE I need to make sure keys aren't overridden. Come back and fix
    puts "What product are you looking to add"
    user_product = gets.chomp.downcase
    if database[user_product].nil?
      puts "What is the price"
      user_price = gets.chomp.to_i
      record[2] = user_price
      record[0] = rand(100..999)
      record[1] = user_product
      database[record[0].to_i] = [record[1], format("%.2f", record[2])]
    else
      puts "That product already exists"
    end
    puts "Item   Description       Price"
    puts "-----  --------------    ------"
    database.each do |record_id, item|
      product_id = record_id.to_s
      puts "#{product_id.ljust(6)} #{item[0].ljust(10)} #{item[1].rjust(13)}"
    end

  elsif user_choice == 3
    puts "Item   Description       Price"
    puts "-----  --------------    ------"
    database.each do |record_id, item|
      product_id = record_id.to_s
      puts "#{product_id.ljust(6)} #{item[0].ljust(10)} #{item[1].rjust(13)}"
    end
    puts "Enter the item number you want to delete: "
    user_delete = gets.chomp.to_i
    if database[user_delete].nil?
      puts "The product id #{user_delete} doesn't exist"
    else
      database.delete(user_delete)
    end
    puts "Item   Description       Price"
    puts "-----  --------------    ------"
    database.each do |record_id, item|
      product_id = record_id.to_s
      puts "#{product_id.ljust(6)} #{item[0].ljust(10)} #{item[1].rjust(13)}"
    end
  elsif user_choice == 4
    puts "Item   Description        Price"
    puts "-----  --------------     ------"
    database.each do |record_id, item|
      product_id = record_id.to_s
      puts "#{product_id.ljust(6)} #{item[0].ljust(10)} #{item[1].rjust(13)}"
    end
    puts "Enter the product number you are looking to update."
    user_update = gets.chomp.to_i
    while (other_choice = small_menu(small_menu_items)) != (small_menu_items.length + 1)
      if other_choice == 1
        record[0] = user_update
        puts "Enter description: "
        product_change = gets.chomp
        record[1] = product_change
        database[record[0].to_i] = [record[1], format("%.2f", record[2])]
      elsif other_choice == 2
        record[0] = user_update
        puts "Enter description: "
        price_change = gets.chomp
        record[2] = price_change
        database[record[0].to_i] = [record[1], format("%.2f", record[2])]
      else
        # I need to fix this error so my code points this when an invalid product ID is inputted.
        puts "The product id #{user_update} doesn't exist"
      end
    end
  elsif user_choice == 5
    prices = []
    database.each do |record_id, item|
      prices << item[1].to_f
    end
    highest_price = prices.max
    puts "This is highest price: $#{format("%.2f", highest_price)}"

  elsif user_choice == 6
    prices = []
    database.each do |record_id, item|
      prices << item[1].to_f
    end
    lowest_price = prices.min
    puts "This is the lowest price: $#{format("%.2f", lowest_price)}"
    database.each do |record_id, item|
      price = [item[1]]
      if price == lowest_price
        puts "#{record_id}, #{item}, #{item[1]}"
      end
    end
  elsif user_choice == 7
    prices = []
    database.each do |record_id, item|
      puts "#{record_id}, #{item[0]}, #{item[1]}"
      prices << item[1].to_f
    end
    sum_prices = prices.inject(0, :+)
    puts "Total of all products: $#{format("%.2f", sum_prices)}"
  end
  puts "Invalid choice. Please choose from the user menu: "
end
puts "Good Bye."


# This is something I am working on for option 2 to add to data base having an error occur string to integer convert.


products_file = File.open("products.txt", "w")

database.each do |record_id, items|
  # write to file
  products_file.puts "#{record_id},#{items[0]},#{items[1]}"
end

products_file.close


# Trial 5 data type conversions when we get the data
=begin
database = {}
until people_file.eof?
  record = people_file.gets.chomp.split(", ")

  # convert age to integer
  record[1] = record[1].to_i
  database[rand(1..20)] = record

end

# print a report
# person is x years in dog years
database.each do |record_id, record|
  puts "#{record[0]} is #{record[1] * 7} years old in dog years"
end
=end
# close the txt file here and work with the database file you create.


# movies = {
#     StarWars: 4.8,
#     Divergent: 4.7
# }
#
# puts "What would you like to do? "
# puts "Add movie?"
# puts "Update a movie?"
# puts "Display the movies?"
# puts "Delete movies?"
# puts "Exit"
#
# choice = gets.chomp
#
# case choice
# when "add"
#   puts "What movie would you like to add? "
#   title = gets.chomp
#   if movies[title.to_sym].nil?
#     puts "What rating does the movie have? "
#     rating = gets.chomp
#     movies[title.to_sym] = rating.to_i
#   else
#     puts "That movie already exists! Its rating is #{movies[title.to_sym]}."
#   end
# when "update"
#   puts "What movie would you like to update? "
#   title = gets.chomp
#   if movies[title.to_sym].nil?
#     puts "That movie does not exist."
#   else
#     puts "What is the new rating? "
#     rating = gets.chomp
#     movies[title.to_sym] = rating.to_i
#   end
# when "display"
#   movies.each do |title, rating|
#     puts "#{title}: #{rating}"
#   end
# when "delete"
#   puts "What movie would you like to delete? "
#   title = gets.chomp
#   if movies[title.to_sym].nil?
#     puts "That movie does not exist."
#   else
#     puts movies.delete(title)
#   end
# else
#   puts "Good bye."
# end


