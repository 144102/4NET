(function () {
    "use strict";



    // On  défini la clé de grouping, le nom du groupe, et comment différentier les différentes valeurs
  
    var data = new WinJS.Binding.List([
{
    "_id": "566ad3c23e1c0f785b700484",
    "index": 0,
    "guid": "033a1455-7139-44cf-b6cb-fe0c60794f90",
    "isActive": true,
    "balance": "$3,001.38",
    "picture": "http://placehold.it/32x32",
    "age": 33,
    "eyeColor": "brown",
    "name": "Murphy Bridges",
    "gender": "male",
    "company": "ENORMO",
    "email": "murphybridges@enormo.com",
    "phone": "+1 (814) 483-2833",
    "address": "795 Polhemus Place, Austinburg, Illinois, 4364",
    "about": "Commodo commodo ut proident consequat qui est eu incididunt laboris. Tempor eiusmod consequat nisi eiusmod non ad dolor est aliqua. Duis eiusmod commodo anim laborum consequat fugiat tempor pariatur. Duis eu non excepteur voluptate magna cupidatat cupidatat quis sit cupidatat mollit irure. Non deserunt excepteur veniam sint sit magna ipsum. Consequat adipisicing aute fugiat dolor dolore magna eu aute. Sint voluptate enim magna fugiat cupidatat voluptate ex.\r\n",
    "registered": "2015-05-20T06:44:40 -02:00",
    "latitude": -57.727631,
    "longitude": 159.293136,
    "tags": [
      "labore",
      "dolor",
      "proident",
      "ut",
      "nostrud",
      "labore",
      "tempor"
    ],
    "friends": [
      {
          "id": 0,
          "name": "Gretchen Sargent"
      },
      {
          "id": 1,
          "name": "Lindsay Mcmahon"
      },
      {
          "id": 2,
          "name": "Carr Ochoa"
      }
    ],
    "greeting": "Hello, Murphy Bridges! You have 4 unread messages.",
    "favoriteFruit": "banana"
},
{
    "_id": "566ad3c2e725cb2d8fe1408f",
    "index": 1,
    "guid": "ef1f18e0-98fc-46bb-8862-21214cb4a3ed",
    "isActive": false,
    "balance": "$1,845.77",
    "picture": "http://placehold.it/32x32",
    "age": 30,
    "eyeColor": "green",
    "name": "Collier Rice",
    "gender": "male",
    "company": "NETILITY",
    "email": "collierrice@netility.com",
    "phone": "+1 (818) 422-2995",
    "address": "113 Bedell Lane, Walland, Pennsylvania, 9754",
    "about": "Lorem magna cupidatat est eu mollit ex officia cillum dolore sint excepteur ullamco ullamco. Officia ipsum mollit mollit labore proident do eiusmod. Reprehenderit elit et sunt minim voluptate sint occaecat cillum qui deserunt ipsum velit. Ea culpa culpa ipsum do mollit voluptate ut minim. Labore excepteur consectetur laborum occaecat ad. Adipisicing velit reprehenderit adipisicing minim nisi exercitation duis enim ipsum elit duis qui commodo ex.\r\n",
    "registered": "2014-05-27T10:36:06 -02:00",
    "latitude": -9.104258,
    "longitude": 163.299606,
    "tags": [
      "incididunt",
      "pariatur",
      "esse",
      "do",
      "ullamco",
      "fugiat",
      "minim"
    ],
    "friends": [
      {
          "id": 0,
          "name": "Reid Bray"
      },
      {
          "id": 1,
          "name": "Britney Cherry"
      },
      {
          "id": 2,
          "name": "Martha Martinez"
      }
    ],
    "greeting": "Hello, Collier Rice! You have 2 unread messages.",
    "favoriteFruit": "apple"
},
{
    "_id": "566ad3c26878ea48bd8298d1",
    "index": 2,
    "guid": "9f3bb7b8-a2d6-4fe1-bd5e-035388791d31",
    "isActive": false,
    "balance": "$3,536.12",
    "picture": "http://placehold.it/32x32",
    "age": 36,
    "eyeColor": "green",
    "name": "Kathryn Lindsay",
    "gender": "female",
    "company": "COMTRAK",
    "email": "kathrynlindsay@comtrak.com",
    "phone": "+1 (840) 505-3922",
    "address": "705 Poplar Avenue, Caron, Nebraska, 1272",
    "about": "Est dolor proident ut non ut ea sit incididunt ad. Aute aute labore elit Lorem cupidatat eu eiusmod sunt adipisicing. Veniam fugiat aliqua occaecat exercitation et culpa. Labore voluptate sunt ex adipisicing ad eiusmod elit ex laborum. Aliquip tempor aliqua fugiat sunt amet occaecat exercitation deserunt in incididunt sint. Commodo exercitation aute ad ea dolor nisi eiusmod.\r\n",
    "registered": "2015-03-31T03:48:53 -02:00",
    "latitude": 13.067787,
    "longitude": -71.01946,
    "tags": [
      "eu",
      "ipsum",
      "sunt",
      "ex",
      "excepteur",
      "irure",
      "dolore"
    ],
    "friends": [
      {
          "id": 0,
          "name": "Stella Mcclure"
      },
      {
          "id": 1,
          "name": "John Cohen"
      },
      {
          "id": 2,
          "name": "Mullins Ramirez"
      }
    ],
    "greeting": "Hello, Kathryn Lindsay! You have 6 unread messages.",
    "favoriteFruit": "banana"
},
{
    "_id": "566ad3c298f657f2a888f234",
    "index": 3,
    "guid": "d642ecdf-c39a-4093-af29-cf29cf939ddd",
    "isActive": false,
    "balance": "$3,187.87",
    "picture": "http://placehold.it/32x32",
    "age": 22,
    "eyeColor": "green",
    "name": "Cantrell Knapp",
    "gender": "male",
    "company": "QUONK",
    "email": "cantrellknapp@quonk.com",
    "phone": "+1 (999) 555-2119",
    "address": "273 Livingston Street, Sussex, Maine, 5769",
    "about": "Quis enim sint est ipsum sint incididunt reprehenderit nisi non pariatur consequat velit. Tempor occaecat est veniam consectetur in velit ad ut cupidatat Lorem sunt ex et. Cupidatat aute dolor duis Lorem.\r\n",
    "registered": "2015-01-10T10:10:33 -01:00",
    "latitude": -76.769165,
    "longitude": -55.176743,
    "tags": [
      "veniam",
      "consequat",
      "sint",
      "officia",
      "velit",
      "enim",
      "aliqua"
    ],
    "friends": [
      {
          "id": 0,
          "name": "Casandra Patterson"
      },
      {
          "id": 1,
          "name": "Leola Vaughan"
      },
      {
          "id": 2,
          "name": "Greta Patton"
      }
    ],
    "greeting": "Hello, Cantrell Knapp! You have 3 unread messages.",
    "favoriteFruit": "apple"
},
{
    "_id": "566ad3c21d87244401366b39",
    "index": 4,
    "guid": "9e0bd99a-93d1-4312-ad44-5879b7785653",
    "isActive": true,
    "balance": "$1,758.98",
    "picture": "http://placehold.it/32x32",
    "age": 32,
    "eyeColor": "brown",
    "name": "Hampton Bolton",
    "gender": "male",
    "company": "GEOFORMA",
    "email": "hamptonbolton@geoforma.com",
    "phone": "+1 (984) 512-2564",
    "address": "880 Manor Court, Stewart, Massachusetts, 8569",
    "about": "Ex laboris non voluptate culpa irure. Aliquip voluptate cillum sint labore est ea magna. Nisi exercitation ad pariatur et incididunt aliqua sunt ut laborum. Aute labore nisi fugiat in cillum anim occaecat ad voluptate dolore ullamco. Culpa dolor pariatur ea aliqua irure dolore qui irure ex ipsum incididunt.\r\n",
    "registered": "2014-11-10T03:03:39 -01:00",
    "latitude": 16.658355,
    "longitude": 138.813727,
    "tags": [
      "dolore",
      "incididunt",
      "adipisicing",
      "aliquip",
      "velit",
      "adipisicing",
      "aliqua"
    ],
    "friends": [
      {
          "id": 0,
          "name": "Finch Foster"
      },
      {
          "id": 1,
          "name": "Martin Rutledge"
      },
      {
          "id": 2,
          "name": "Petty Avery"
      }
    ],
    "greeting": "Hello, Hampton Bolton! You have 9 unread messages.",
    "favoriteFruit": "strawberry"
}
    ]);

    var listGroupedByIsActive = data.createGrouped(
        function getGroupByIsActiveKey(dataItem) { return dataItem.isActive; },
        function getGroupByIsActiveData(dataItem) { return { groupDescription: "IsActive's value : " + dataItem.isActive }; }
    );


    WinJS.Namespace.define("Test",
    {
        groupsIsActive: listGroupedByIsActive
    });





    var list = new WinJS.Binding.List();
    var groupedItems = list.createGrouped(
        function groupKeySelector(item) { return item.group.key; },
        function groupDataSelector(item) { return item.group; }
    );

    //// TODO: Replace the data with your real data.
    // You can add data from asynchronous sources whenever it becomes available.
    generateSampleData().forEach(function (item) {
        list.push(item);
    });

    WinJS.Namespace.define("Data", {
        items: groupedItems,
        groups: groupedItems.groups,
        getItemReference: getItemReference,
        getItemsFromGroup: getItemsFromGroup,
        resolveGroupReference: resolveGroupReference,
        resolveItemReference: resolveItemReference
    });





    // Get a reference for an item, using the group key and item title as a
    // unique reference to the item that can be easily serialized.
    function getItemReference(item) {
        return [item.group.key, item.title];
    }

    // This function returns a WinJS.Binding.List containing only the items
    // that belong to the provided group.
    function getItemsFromGroup(group) {
        return list.createFiltered(function (item) { return item.group.key === group.key; });
    }

    // Get the unique group corresponding to the provided group key.
    function resolveGroupReference(key) {
        return groupedItems.groups.getItemFromKey(key).data;
    }

    // Get a unique item from the provided string array, which should contain a
    // group key and an item title.
    function resolveItemReference(reference) {
        for (var i = 0; i < groupedItems.length; i++) {
            var item = groupedItems.getAt(i);
            if (item.group.key === reference[0] && item.title === reference[1]) {
                return item;
            }
        }
    }

    // Returns an array of sample data that can be added to the application's
    // data list. 
    function generateSampleData() {
        var itemContent = "<p>Curabitur class aliquam vestibulum nam curae maecenas sed integer cras phasellus suspendisse quisque donec dis praesent accumsan bibendum pellentesque condimentum adipiscing etiam consequat vivamus dictumst aliquam duis convallis scelerisque est parturient ullamcorper aliquet fusce suspendisse nunc hac eleifend amet blandit facilisi condimentum commodo scelerisque faucibus aenean ullamcorper ante mauris dignissim consectetuer nullam lorem vestibulum habitant conubia elementum pellentesque morbi facilisis arcu sollicitudin diam cubilia aptent vestibulum auctor eget dapibus pellentesque inceptos leo egestas interdum nulla consectetuer suspendisse adipiscing pellentesque proin lobortis sollicitudin augue elit mus congue fermentum parturient fringilla euismod feugiat</p><p>Curabitur class aliquam vestibulum nam curae maecenas sed integer cras phasellus suspendisse quisque donec dis praesent accumsan bibendum pellentesque condimentum adipiscing etiam consequat vivamus dictumst aliquam duis convallis scelerisque est parturient ullamcorper aliquet fusce suspendisse nunc hac eleifend amet blandit facilisi condimentum commodo scelerisque faucibus aenean ullamcorper ante mauris dignissim consectetuer nullam lorem vestibulum habitant conubia elementum pellentesque morbi facilisis arcu sollicitudin diam cubilia aptent vestibulum auctor eget dapibus pellentesque inceptos leo egestas interdum nulla consectetuer suspendisse adipiscing pellentesque proin lobortis sollicitudin augue elit mus congue fermentum parturient fringilla euismod feugiat</p><p>Curabitur class aliquam vestibulum nam curae maecenas sed integer cras phasellus suspendisse quisque donec dis praesent accumsan bibendum pellentesque condimentum adipiscing etiam consequat vivamus dictumst aliquam duis convallis scelerisque est parturient ullamcorper aliquet fusce suspendisse nunc hac eleifend amet blandit facilisi condimentum commodo scelerisque faucibus aenean ullamcorper ante mauris dignissim consectetuer nullam lorem vestibulum habitant conubia elementum pellentesque morbi facilisis arcu sollicitudin diam cubilia aptent vestibulum auctor eget dapibus pellentesque inceptos leo egestas interdum nulla consectetuer suspendisse adipiscing pellentesque proin lobortis sollicitudin augue elit mus congue fermentum parturient fringilla euismod feugiat</p><p>Curabitur class aliquam vestibulum nam curae maecenas sed integer cras phasellus suspendisse quisque donec dis praesent accumsan bibendum pellentesque condimentum adipiscing etiam consequat vivamus dictumst aliquam duis convallis scelerisque est parturient ullamcorper aliquet fusce suspendisse nunc hac eleifend amet blandit facilisi condimentum commodo scelerisque faucibus aenean ullamcorper ante mauris dignissim consectetuer nullam lorem vestibulum habitant conubia elementum pellentesque morbi facilisis arcu sollicitudin diam cubilia aptent vestibulum auctor eget dapibus pellentesque inceptos leo egestas interdum nulla consectetuer suspendisse adipiscing pellentesque proin lobortis sollicitudin augue elit mus congue fermentum parturient fringilla euismod feugiat</p><p>Curabitur class aliquam vestibulum nam curae maecenas sed integer cras phasellus suspendisse quisque donec dis praesent accumsan bibendum pellentesque condimentum adipiscing etiam consequat vivamus dictumst aliquam duis convallis scelerisque est parturient ullamcorper aliquet fusce suspendisse nunc hac eleifend amet blandit facilisi condimentum commodo scelerisque faucibus aenean ullamcorper ante mauris dignissim consectetuer nullam lorem vestibulum habitant conubia elementum pellentesque morbi facilisis arcu sollicitudin diam cubilia aptent vestibulum auctor eget dapibus pellentesque inceptos leo egestas interdum nulla consectetuer suspendisse adipiscing pellentesque proin lobortis sollicitudin augue elit mus congue fermentum parturient fringilla euismod feugiat</p><p>Curabitur class aliquam vestibulum nam curae maecenas sed integer cras phasellus suspendisse quisque donec dis praesent accumsan bibendum pellentesque condimentum adipiscing etiam consequat vivamus dictumst aliquam duis convallis scelerisque est parturient ullamcorper aliquet fusce suspendisse nunc hac eleifend amet blandit facilisi condimentum commodo scelerisque faucibus aenean ullamcorper ante mauris dignissim consectetuer nullam lorem vestibulum habitant conubia elementum pellentesque morbi facilisis arcu sollicitudin diam cubilia aptent vestibulum auctor eget dapibus pellentesque inceptos leo egestas interdum nulla consectetuer suspendisse adipiscing pellentesque proin lobortis sollicitudin augue elit mus congue fermentum parturient fringilla euismod feugiat</p><p>Curabitur class aliquam vestibulum nam curae maecenas sed integer cras phasellus suspendisse quisque donec dis praesent accumsan bibendum pellentesque condimentum adipiscing etiam consequat vivamus dictumst aliquam duis convallis scelerisque est parturient ullamcorper aliquet fusce suspendisse nunc hac eleifend amet blandit facilisi condimentum commodo scelerisque faucibus aenean ullamcorper ante mauris dignissim consectetuer nullam lorem vestibulum habitant conubia elementum pellentesque morbi facilisis arcu sollicitudin diam cubilia aptent vestibulum auctor eget dapibus pellentesque inceptos leo egestas interdum nulla consectetuer suspendisse adipiscing pellentesque proin lobortis sollicitudin augue elit mus congue fermentum parturient fringilla euismod feugiat";
        var itemDescription = "Item Description: Pellentesque porta mauris quis interdum vehicula urna sapien ultrices velit nec venenatis dui odio in augue cras posuere enim a cursus convallis neque turpis malesuada erat ut adipiscing neque tortor ac erat";
        var groupDescription = "Group Description: Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus tempor scelerisque lorem in vehicula. Aliquam tincidunt, lacus ut sagittis tristique, turpis massa volutpat augue, eu rutrum ligula ante a ante";

        // These three strings encode placeholder images. You will want to set the
        // backgroundImage property in your real data to be URLs to images.
        var darkGray = "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAAEAAAABCAYAAAAfFcSJAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsQAAA7EAZUrDhsAAAANSURBVBhXY3B0cPoPAANMAcOba1BlAAAAAElFTkSuQmCC";
        var lightGray = "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAAEAAAABCAYAAAAfFcSJAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsQAAA7EAZUrDhsAAAANSURBVBhXY7h4+cp/AAhpA3h+ANDKAAAAAElFTkSuQmCC";
        var mediumGray = "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAAEAAAABCAYAAAAfFcSJAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsQAAA7EAZUrDhsAAAANSURBVBhXY5g8dcZ/AAY/AsAlWFQ+AAAAAElFTkSuQmCC";

        // Each of these sample groups must have a unique key to be displayed
        // separately.
        var sampleGroups = [
            { key: "group1", title: "Group Title: 1", subtitle: "Group Subtitle: 1", backgroundImage: darkGray, description: groupDescription },
            { key: "group2", title: "Group Title: 2", subtitle: "Group Subtitle: 2", backgroundImage: lightGray, description: groupDescription },
            { key: "group3", title: "Group Title: 3", subtitle: "Group Subtitle: 3", backgroundImage: mediumGray, description: groupDescription },
            { key: "group4", title: "Group Title: 4", subtitle: "Group Subtitle: 4", backgroundImage: lightGray, description: groupDescription },
            { key: "group5", title: "Group Title: 5", subtitle: "Group Subtitle: 5", backgroundImage: mediumGray, description: groupDescription },
            { key: "group6", title: "Group Title: 6", subtitle: "Group Subtitle: 6", backgroundImage: darkGray, description: groupDescription }
        ];

        // Each of these sample items should have a reference to a particular
        // group.
        var sampleItems = [
            { group: sampleGroups[0], title: "Item Title: 1", subtitle: "Item Subtitle: 1", description: itemDescription, content: itemContent, backgroundImage: lightGray },
            { group: sampleGroups[0], title: "Item Title: 2", subtitle: "Item Subtitle: 2", description: itemDescription, content: itemContent, backgroundImage: darkGray },
            { group: sampleGroups[0], title: "Item Title: 3", subtitle: "Item Subtitle: 3", description: itemDescription, content: itemContent, backgroundImage: mediumGray },
            { group: sampleGroups[0], title: "Item Title: 4", subtitle: "Item Subtitle: 4", description: itemDescription, content: itemContent, backgroundImage: darkGray },
            { group: sampleGroups[0], title: "Item Title: 5", subtitle: "Item Subtitle: 5", description: itemDescription, content: itemContent, backgroundImage: mediumGray },

            { group: sampleGroups[1], title: "Item Title: 1", subtitle: "Item Subtitle: 1", description: itemDescription, content: itemContent, backgroundImage: darkGray },
            { group: sampleGroups[1], title: "Item Title: 2", subtitle: "Item Subtitle: 2", description: itemDescription, content: itemContent, backgroundImage: mediumGray },
            { group: sampleGroups[1], title: "Item Title: 3", subtitle: "Item Subtitle: 3", description: itemDescription, content: itemContent, backgroundImage: lightGray },

            { group: sampleGroups[2], title: "Item Title: 1", subtitle: "Item Subtitle: 1", description: itemDescription, content: itemContent, backgroundImage: mediumGray },
            { group: sampleGroups[2], title: "Item Title: 2", subtitle: "Item Subtitle: 2", description: itemDescription, content: itemContent, backgroundImage: lightGray },
            { group: sampleGroups[2], title: "Item Title: 3", subtitle: "Item Subtitle: 3", description: itemDescription, content: itemContent, backgroundImage: darkGray },
            { group: sampleGroups[2], title: "Item Title: 4", subtitle: "Item Subtitle: 4", description: itemDescription, content: itemContent, backgroundImage: lightGray },
            { group: sampleGroups[2], title: "Item Title: 5", subtitle: "Item Subtitle: 5", description: itemDescription, content: itemContent, backgroundImage: mediumGray },
            { group: sampleGroups[2], title: "Item Title: 6", subtitle: "Item Subtitle: 6", description: itemDescription, content: itemContent, backgroundImage: darkGray },
            { group: sampleGroups[2], title: "Item Title: 7", subtitle: "Item Subtitle: 7", description: itemDescription, content: itemContent, backgroundImage: mediumGray },

            { group: sampleGroups[3], title: "Item Title: 1", subtitle: "Item Subtitle: 1", description: itemDescription, content: itemContent, backgroundImage: darkGray },
            { group: sampleGroups[3], title: "Item Title: 2", subtitle: "Item Subtitle: 2", description: itemDescription, content: itemContent, backgroundImage: lightGray },
            { group: sampleGroups[3], title: "Item Title: 3", subtitle: "Item Subtitle: 3", description: itemDescription, content: itemContent, backgroundImage: darkGray },
            { group: sampleGroups[3], title: "Item Title: 4", subtitle: "Item Subtitle: 4", description: itemDescription, content: itemContent, backgroundImage: lightGray },
            { group: sampleGroups[3], title: "Item Title: 5", subtitle: "Item Subtitle: 5", description: itemDescription, content: itemContent, backgroundImage: mediumGray },
            { group: sampleGroups[3], title: "Item Title: 6", subtitle: "Item Subtitle: 6", description: itemDescription, content: itemContent, backgroundImage: lightGray },

            { group: sampleGroups[4], title: "Item Title: 1", subtitle: "Item Subtitle: 1", description: itemDescription, content: itemContent, backgroundImage: lightGray },
            { group: sampleGroups[4], title: "Item Title: 2", subtitle: "Item Subtitle: 2", description: itemDescription, content: itemContent, backgroundImage: darkGray },
            { group: sampleGroups[4], title: "Item Title: 3", subtitle: "Item Subtitle: 3", description: itemDescription, content: itemContent, backgroundImage: lightGray },
            { group: sampleGroups[4], title: "Item Title: 4", subtitle: "Item Subtitle: 4", description: itemDescription, content: itemContent, backgroundImage: mediumGray },

            { group: sampleGroups[5], title: "Item Title: 1", subtitle: "Item Subtitle: 1", description: itemDescription, content: itemContent, backgroundImage: lightGray },
            { group: sampleGroups[5], title: "Item Title: 2", subtitle: "Item Subtitle: 2", description: itemDescription, content: itemContent, backgroundImage: darkGray },
            { group: sampleGroups[5], title: "Item Title: 3", subtitle: "Item Subtitle: 3", description: itemDescription, content: itemContent, backgroundImage: mediumGray },
            { group: sampleGroups[5], title: "Item Title: 4", subtitle: "Item Subtitle: 4", description: itemDescription, content: itemContent, backgroundImage: darkGray },
            { group: sampleGroups[5], title: "Item Title: 5", subtitle: "Item Subtitle: 5", description: itemDescription, content: itemContent, backgroundImage: lightGray },
            { group: sampleGroups[5], title: "Item Title: 6", subtitle: "Item Subtitle: 6", description: itemDescription, content: itemContent, backgroundImage: mediumGray },
            { group: sampleGroups[5], title: "Item Title: 7", subtitle: "Item Subtitle: 7", description: itemDescription, content: itemContent, backgroundImage: darkGray },
            { group: sampleGroups[5], title: "Item Title: 8", subtitle: "Item Subtitle: 8", description: itemDescription, content: itemContent, backgroundImage: lightGray }
        ];

        return sampleItems;
    }
})();
