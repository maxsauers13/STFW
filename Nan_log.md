# STFW

## 2/15/2022
- character can move horizontally, and jump infinitely in the air(need to add ground detection)

## 2/16/2022
- add ground detection for jumping
- add ladder(function)


## 2/19/2022
- add camera follow(cinemachine)
The camera's parameter should be adjust during QA Testing. (a short tutorial is here:https://www.youtube.com/watch?v=2jTY11Am0Ig)
- add infinite scrolling background (tutorial: https://www.youtube.com/watch?v=zit45k6CUMk)
- ! camera confiner may have some problems due to conflicts with infinite scrolling background


## 2/20/2022
- add background
- add collider property to some tiles

## 3/1/2022
- player are able to pick up items now 

## 3/7/2022
- a dialogue box will appear above the character when examining an item and disappear a few seconds later


## 3/10/2022
- start working on inventory system

## 3/20/2022
- add item panel and item information window
- player can pick up items(only for PickUp type items), item image will show in the panel at the bottom
- player can find their information at bottom right corner
- player can consume the item and the item will disappear

## 3/21/2022
- add grabble item type (for weapons) (ONLY FIRST THREE GRIDS CAN GRAB ITEM, because I am (~~lazy~~) considering add a separate item panel for weapons)
- player can grab grabbale item on hand and drop it by clicking it on the item panel again 

## 3/22/2022
- detected bug: when Grab and Consume function use the same event trigger, IndexOutoOfRange error occur
- SOLUTION: use different event trigger: Pointer Click -> consume; Pointer Down -> grab
- add health and hunger bar: when hunger reach 0, health decreases over time; when hunger != 0, hunger decreases over time.

## 3/23/2022
- can stack item now


## 3/24/2022
- add health & hunger effect attributes to items, health & hunger bar will change when consuming items
- solve the bug occur when item count is over the limit
- able to fetch items from chest by clicking it

## 3/27/2022
- add day&night system
- date and time will show on the screen
- add mouse event, player consume and grab items by right click

## 4/1/2022
- complete upper ground map design

## 4/9/2022
- add animation for the character

## 4/10/2022
- start working on underground map design

## 4/12/2022
- start working on lab design
- add toxin concentration

## 4/17/2022
- add zombie and animation

## 4/18/2022
- start working on underground room
- add elevator

NEED TO DO：
 1. ~~be able to drop the item~~
 2. ~~stacked item~~
 3. chest

SHOULD ADJUST IN TESTING PHASE:
- camera position
- decreasing rate for health, hunger, and toxin concentration
- grabbed item position to the player
