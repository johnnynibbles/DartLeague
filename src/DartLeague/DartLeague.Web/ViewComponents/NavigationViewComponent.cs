﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DartLeague.Web.ViewComponents.Models.Navigation;

namespace DartLeague.Web.Controllers.Components
{
    public class NavigationViewComponent : ViewComponent
    {
        public NavigationViewComponent()
        {
        }

        public async Task<IViewComponentResult> InvokeAsync(string template)
        {
            var model = NavBuilder(Url, template);
            return View(model);
        }


        public static SiteNavigationViewModel NavBuilder(IUrlHelper url, string name = "Default")
        {
            switch (name)
            {
                case "DartsForDreams":
                    return DartsForDreamsNavigation(url);
                case "Manage":
                    return ManagementNavigation(url);
                default:
                    return DefaultNavigation(url);
            }
        }

        private static SiteNavigationViewModel DefaultNavigation(IUrlHelper url)
        {
            return new SiteNavigationViewModel
            {
                ParentNavigations = {
                    new NavigationViewModel
                    {
                        Title = "Current",
                        SubNavigations =
                        {
                            new NavigationViewModel
                            {
                                Title = "Weekly Standings",
                                Href = url.Action("Index", "Home", null)
                            },
                            new NavigationViewModel
                            {
                                Title = "Full Schedule"
                            },
                            new NavigationViewModel
                            {
                                Title = "Stats"
                            },
                            new NavigationViewModel
                            {
                                Title = "Leaderboards"
                            },
                            new NavigationViewModel
                            {
                                Title = "Awards"
                            },
                            new NavigationViewModel
                            {
                                Title = "Teams"
                            }
                        }
                    },
                    new NavigationViewModel
                    {
                        Title="Activities and Events",
                        SubNavigations =
                        {
                            new NavigationViewModel
                            {
                                Title = "Memorial Tournament Bracket"
                            },
                            new NavigationViewModel
                            {
                                Title = "Memorial Tournament Info"
                            },
                            new NavigationViewModel
                            {
                                Title = "Mr. Trenton Bracket"
                            },
                            new NavigationViewModel
                            {
                                Title = "Mr. Trenton Rules"
                            },
                            new NavigationViewModel
                            {
                                Title = "All Star Qualifying Info"
                            },
                            new NavigationViewModel
                            {
                                Title = "Winter Singles League"
                            },
                            new NavigationViewModel
                            {
                                Title = "Summer Singles Weekly"
                            },
                            new NavigationViewModel
                            {
                                Title = "Summer Singles Schedule"
                            },
                            new NavigationViewModel
                            {
                                Title = "NJ State Cricket Championship"
                            },
                            new NavigationViewModel
                            {
                                Title = "Darts for Dreams Info"
                            },
                            new NavigationViewModel
                            {
                                Title = "GTDL Player Results at Events"
                            }
                        }
                    },
                    new NavigationViewModel
                    {
                        Title="League",
                        SubNavigations =
                        {
                            new NavigationViewModel
                            {
                                Title="Where we Play"
                            },
                            new NavigationViewModel
                            {
                                Title="Sponsors and Partners",
                                Href = url.Action("Index", "Sponsor")
                            },
                            new NavigationViewModel
                            {
                                Title = "Darts in the Region"
                            },
                            new NavigationViewModel
                            {
                                Title = "Board Members"
                            },
                            new NavigationViewModel
                            {
                                Title="Contact"
                            }
                        }
                    },
                    new NavigationViewModel
                    {
                        Title="History",
                        SubNavigations =
                        {
                            new NavigationViewModel
                            {
                                Title="2015 - 2016"
                            },
                            new NavigationViewModel
                            {
                                Title = "2014 - 2015"
                            },
                            new NavigationViewModel
                            {
                                Title = "2013 - 2014"
                            },
                            new NavigationViewModel
                            {
                                Title = "2012 - 2013"
                            },
                            new NavigationViewModel
                            {
                                Title = "2011 - 2012"
                            },
                            new NavigationViewModel
                            {
                                Title = "2010 - 2011"
                            },
                            new NavigationViewModel
                            {
                                Title = "2009 - 2010"
                            }
                        }
                    },
                    new NavigationViewModel
                    {
                        Title="Other",
                        SubNavigations =
                        {
                            new NavigationViewModel
                            {
                                Title = "League Rules"
                            },
                            new NavigationViewModel
                            {
                                Title = "Sponsor Paperwork"
                            },
                            new NavigationViewModel
                            {
                                Title = "Player Registration"
                            },
                            new NavigationViewModel
                            {
                                Title = "Roster Sheet"
                            },
                            new NavigationViewModel
                            {
                                Title = "Scoresheet"
                            },
                            new NavigationViewModel
                            {
                                Title = "Chalker Guidelines"
                            },
                            new NavigationViewModel
                            {
                                Title = "01 Strategy"
                            },
                            new NavigationViewModel
                            {
                                Title = "Cricket Strategy"
                            }
                        }
                    }
                }
            };
        }

        private static SiteNavigationViewModel ManagementNavigation(IUrlHelper url)
        {
            return new SiteNavigationViewModel
            {
                ParentNavigations =
                {
                    new NavigationViewModel
                    {
                        Title = "Home",
                        Href = url.Action("Index", "Home", new {Area = "Manage"})
                    },
                    new NavigationViewModel
                    {
                        Title = "Site",
                        Href = "#",
                        SubNavigations = {
                            new NavigationViewModel{ Title = "Dart Events", Href = url.Action("Index", "DartEvent", new {Area = "Site" })},
                            new NavigationViewModel{ Title = "Page Content", Href = "manage.site.pagepart.index"}
                        }
                    },
                    new NavigationViewModel {
                        Title = "League",
                        Href = "#",
                        SubNavigations = {
                            new NavigationViewModel{ Title = "Players", Href = url.Action("Index", "Player", new {Area = "Manage" }) },
                            new NavigationViewModel{ Title = "Teams", Href = "manage.team.index"},
                            new NavigationViewModel{ Title = "Sponsors", Href = url.Action("Index", "Sponsor", new {Area = "Manage" })},
                            new NavigationViewModel{ Title = "Board Members", Href = "manage.boardmember.index"},
                        }
                    },
                    new NavigationViewModel
                    {
                        Title = "Seasons",
                        Href = "manage.season.index"
                    }
                }
            };
        }

        private static SiteNavigationViewModel DartsForDreamsNavigation(IUrlHelper url)
        {
            return new SiteNavigationViewModel
            {
                ParentNavigations =
                {
                    new NavigationViewModel
                    {
                        Title = "Darts for Dreams 12 -  April 29th, 2017",
                        SubNavigations = {
                            new NavigationViewModel
                            {
                                Title ="Event Flyer",
                              Href = "documents/events/2016-2017/flier17.pdf"
                            },
                            new NavigationViewModel
                            {
                                Title = "GTDL Player letter",
                              Href = "documents/events/2016-2017/playerletter17.pdf"
                            },
                            new NavigationViewModel
                            {
                                Title = "Player Pledge Sheet",
                                Href = "documents/events/2016-2017/pledge17.pdf"
                            },
                            new NavigationViewModel
                            {
                                Title = "Paperwork for Sponsors",
                                Href = "documents/events/2016-2017/sponsorpackage17.pdf"
                            },
                            new NavigationViewModel
                            {
                                Title = "Current Donation List",
                                Href = "documents/events/2016-2017/donationreport.pdf"
                            },
                            new NavigationViewModel
                            {
                                Title = "Online Donation Form!!",
                                Href = "http://site.wish.org/site/TR/FriendsandFamily/Make-A-WishNewJersey?px=3100639&pg=personal&fr_id=2340"
                            },
                            new NavigationViewModel
                            {
                                Title = "What\"s a dart-a-thon",
                                Href = "documents/events/static/whatisadartathon.pdf"
                            }
                         }
                    },
                    new NavigationViewModel
                    {
                        Title = "History of Events",
                        Href = "#"
                    },
                    new NavigationViewModel
                    {
                        Title = "Return to GTDL",
                        Href = "/"
                    }
                }
            };
        }
    }
}
