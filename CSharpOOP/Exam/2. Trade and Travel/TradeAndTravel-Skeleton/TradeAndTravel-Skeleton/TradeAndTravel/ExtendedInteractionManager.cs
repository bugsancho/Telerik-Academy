using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeAndTravel
{
    class ExtendedInteractionManager : InteractionManager
    {
        protected override void HandlePersonCommand(string[] commandWords, Person actor)
        {
            base.HandlePersonCommand(commandWords, actor);

            switch (commandWords[1])
            {
                case "gather":
                    HandleGatherInteraction(commandWords, actor);
                    break;
                case "craft":
                    HandleCraftInteraction(commandWords, actor);
                    break;

                default:
                    break;
            }

        }

        private void HandleCraftInteraction(string[] commandWords, Person actor)
        {
            switch (commandWords[2])
            {
                case "armor":
                    if (InventoryCointainsItemType(actor, ItemType.Iron))
                    {
                        var armorItem = new Armor(commandWords[3], null);
                        this.AddToPerson(actor, armorItem);
                    }
                    break;
                case "weapon":
                    if (InventoryCointainsItemType(actor, ItemType.Wood))
                    {
                        var weaponItem = new Weapon(commandWords[3], null);
                        this.AddToPerson(actor, weaponItem);
                    }
                    break;
                default:
                    break;
            }

        }
        //Method that searches the inventory of a person for an item of given type
        private bool InventoryCointainsItemType(Person actor, ItemType itemType)
        {
            List<Item> inventoryList = actor.ListInventory();
            foreach (var item in inventoryList)
            {
                if (item.ItemType == itemType)
                {
                    return true;
                }
            }
            return false;
        }

        private void HandleGatherInteraction(string[] commandWords, Person actor)
        {
            switch (actor.Location.LocationType)
            {
                case LocationType.Mine:
                    {
                        var visitedMine = actor.Location as Mine;
                        if (InventoryCointainsItemType(actor, visitedMine.RequiredItem))
                        {
                            var item = visitedMine.ProduceItem(commandWords[2]);
                            this.AddToPerson(actor, item);
                        }
                    }
                    break;

                case LocationType.Forest:
                    {
                        var visitedForest = actor.Location as Forest;

                        if (InventoryCointainsItemType(actor, visitedForest.RequiredItem))
                        {
                            var item = visitedForest.ProduceItem(commandWords[2]);
                            this.AddToPerson(actor, item);

                        }
                    }
                    break;
                default:
                    break;
            }
        }

        protected override Item CreateItem(string itemTypeString, string itemNameString, Location itemLocation, Item item)
        {
            item = base.CreateItem(itemTypeString, itemNameString, itemLocation, item);
            switch (itemTypeString)
            {
                case "weapon": item = new Weapon(itemNameString, itemLocation); break;
                case "wood": item = new Wood(itemNameString, itemLocation); break;
                case "iron": item = new Iron(itemNameString, itemLocation); break;
                default:
                    break;
            }
            return item;
        }
        protected override Location CreateLocation(string locationTypeString, string locationName)
        {
            Location location = base.CreateLocation(locationTypeString, locationName);

            switch (locationTypeString)
            {
                case "mine": location = new Mine(locationName); break;
                case "forest": location = new Forest(locationName); break;
                default:
                    break;
            }

            return location;
        }
        protected override Person CreatePerson(string personTypeString, string personNameString, Location personLocation)
        {
            Person person = base.CreatePerson(personTypeString, personNameString, personLocation);
            switch (personTypeString)
            {
                case "merchant": person = new Merchant(personNameString, personLocation); break;
                default:
                    break;
            }
            return person;
        }
    }
}
