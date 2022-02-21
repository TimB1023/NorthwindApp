# NorthwindApp
Update: Now working on WPF version using Caliburn.Micro to acheive MVVM pattern

A little app to help learn using Winforms and Data Access.
Based on the MS Northwinds database

First window loads and the user is to enter at least two letters of a customer name before the customer search results list is filled
The first in the list is automatically selected, but the user can select any of the others
As soon as a customer is selected (actively or by default), various data about the customer is displayed, including a list of the orders
Note that the grain of the database is line items, not orders, there is therefore some additional processing needed to show each order just once

The user can filter the orders by date using two date pickers. These should be limited to the date range for that particular customer. 
Additionally, they should adapt to each other such that, for example, a latest date filter cannot be set earlier than the earliest date. (currently not working correctly)

If the user clicks on one of the orders, a dialog is opened with further details.
