# Bokio-fullstack-test
 An home work for interview process for Bokio

Bokio fullstack test assignment: Parsing bank data 
 
Expected time 5-10 hours if you have the tools installed. If you can't complete it in that time. Don't worry, this is a ground for a futher discussion and not a pass/fail test. 
 
At Bokio we have a feature where you can go into your internet bank. Do ctrl + a, ctrl + c and then paste this into a textarea and we will parse the bank transactions from that. 
The assignment is to build this functionality.  
From experience, we know that some banks are using frames, in that case it's ok if you focus the transaction table before the copy & paste action (The difference will be that in the paste you only get the relevant rows). 
The banks usually have many columns that aren’t needed. We are interested in the following: 
[Date of payment (first date if there are two dates), The description, The sum, The saldo] 
You are either to figure out how to: 
A) automatically figure out which column in the input goes to which column in the rows B) let the user set it manually  C) or a combination of both. Do what you feel gives the best quality. 
After saving, the rows should be persisted on the server so you can reload the page without losing saved rows. We are not looking at anything advanced. Simply saving to hard-coded file is fine enough for this. 
NOTE: This feature is already built by us and is in production. While it would be possible to copy that code that’s not accepted. If you need that you wouldn’t enjoy working here anyway. 
The use case We are using this in Bokio for letting the users do their accounting faster and more accurately by reading all the dates and sums from the bank. The user only has to categorise the event by getting the dates and sums. 
Basically, this is a hack because the banks don’t have open API's right now. So instead of automatically reading from the bank account the user log into their bank and then copy the whole page and then paste it in Bokio.  
Getting all the bank rows in to system speeds up the bookkeeping a lot for the user as they get the dates, the sum and the title from the bank. 
Stack requirements For the front-end you can choose freely. A recommendation could still be to use Angular and Bootstrap to speed it up a bit. 

 
For the back-end we want to see a asp.net mvc/c# solution but if it's much easier for you, you might use java or nodejs instead. Other than that, you might store the data in any of the following ways. JSON, XML, CSV, Sql server. No user/company management is needed.  
Project template There is a (.net 4.6.1 / asp.net MVC) project included that you are free to use to get started more quickly. You can do all the work in the home controller and the Index view for the home controller.  
 
As previously said you can chose to not use this if you feel it will be better for you. 
Step 1: Making the parser smarter by merging rows You are to make the parsing a bit smarter by making sure that overlapping pastes are handled. 
 
Let say you are pasting this first: 
2016-10-01 TextA 1000kr 
2016-10-02 TextB 1000kr 
 
and this second: 
2016-10-02 TextB 1000kr 
2016-10-02 TextB 1000kr 
2016-10-02 TextC 1500kr 
 
We want the result to be: 
2016-10-01 TextA 1000kr 
2016-10-02 TextB 1000kr 
2016-10-02 TextB 1000kr 
2016-10-02 TextC 1500kr 
 
If there was only one [2016-10-02 TextB 1000kr] row in the second parse there would be one in the result. If there was 2 of those rows in the first parse and 1 in the second there would still be two in the result. 
Tooling Visual studio is probably the easiest. There is a free version if you don't have it already.  https://www.visualstudio.com/vs/community/ 
Test data In the folder there is test data from Handelsbanken and SEB. You should test with your bank too if you have a different one. 
 
We don’t want or need your bank data so please don’t email that to us if there is any sensitive information in it. 