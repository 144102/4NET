using App1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Repositories
{
    public class MusicRepository : IDisposable
    {
        public List<MusicGroup> MusicGroups;
        public MusicRepository()
        {
            MusicGroups = new List<MusicGroup>()
            {
                #region Air
                new MusicGroup
                {
                    UniqueId = 1,
                    Name = "Air",
                    GroupMembers = new List<int>()
                    {
                        1,
                        2
                    },
                    Songs = new List<Song>()
                    {
                        new Song
                        {
                            Name = "La femme d'argent",
                            Album =  "Moon Safari"
                        },
                        new Song
                        {
                            Name = "Talisman",
                            Album =  "Moon Safari"
                        }
                    }
                },
                #endregion
                #region Daft Punk
                new MusicGroup
                {
                    UniqueId = 2,
                    Name = "Daft Punk",
                    GroupMembers = new List<int>()
                    {
                        1,
                        2
                    },
                    Songs = new List<Song>()
                    {
                        new Song
                        {
                            Name = "Give Life Back to Music",
                            Album =  "Random Access Memory"
                        },
                        new Song
                        {
                            Name = "The Game of Love",
                            Album =  "Random Access Memory"
                        },
                        new Song
                        {
                            Name = "Giorgio by Moroder",
                            Album =  "Random Access Memory"
                        },
                        new Song
                        {
                            Name = "Within",
                            Album =  "Random Access Memory"
                        },
                        new Song
                        {
                            Name = "Human After All",
                            Album =  "Human After All"
                        },
                        new Song
                        {
                            Name = "Prime Time Of Your Life",
                            Album =  "Human After All"
                        },
                        new Song
                        {
                            Name = "Robot Rock",
                            Album =  "Human After All"
                        }
                    }
                },
                #endregion
                #region Marvin Gaye
                new MusicGroup
                {
                    UniqueId = 3,
                    Name = "Marvin Gaye",
                    GroupMembers = new List<int>()
                    {
                        1
                    },
                    Songs = new List<Song>()
                    {
                        new Song
                        {
                            Name = "Stubborn Kind Of Fellow (Single - Mono)",
                            Album =  "Gold"
                        },
                        new Song
                        {
                            Name = "Hitch Hike",
                            Album =  "Gold"
                        },
                        new Song
                        {
                            Name = "Trouble Man (Soundtrack Version)",
                            Album =  "Gold"
                        }
                    }
                },
                #endregion
                #region Overwerk
                new MusicGroup
                {
                    UniqueId = 4,
                    Name = "Overwerk",
                    GroupMembers = new List<int>()
                    {
                        1
                    },
                    Songs = new List<Song>()
                    {
                        new Song
                        {
                            Name = "Daybreak",
                            Album =  "After Hours"
                        },
                        new Song
                        {
                            Name = "Relapse",
                            Album =   "After Hours"
                        },
                        new Song
                        {
                            Name = "Signal",
                            Album =   "After Hours"
                        }
                    }
                }
                #endregion
            };
        }

        public void Dispose()
        {
            MusicGroups = null;
        }
    }
}
