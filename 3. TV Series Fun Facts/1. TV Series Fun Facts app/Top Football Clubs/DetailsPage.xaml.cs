using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using GoogleAds;
using System.Diagnostics;

namespace Top_Football_Clubs
{
    public partial class DetailsPage : PhoneApplicationPage
    {
        public DetailsPage()
        {
            InitializeComponent();
        }


        private void OnAdReceived(object sender, GoogleAds.AdEventArgs e)
        {
            Debug.WriteLine("Received ad successfully");
        }

        private void OnFailedToReceiveAd(object sender, GoogleAds.AdErrorEventArgs errorCode)
        {
            Debug.WriteLine("Failed to receive ad with error " + errorCode.ErrorCode);
        }




        int teamCounter;
        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            string msg = "";

            if (NavigationContext.QueryString.TryGetValue("msg", out msg))
            {
                teamCounter = int.Parse(msg);
               

            }


        }

        private void showText_Loaded(object sender, RoutedEventArgs e)
        {
            if (teamCounter==0)
            {
                showText.Text = @" Emilia Clarke Turned Down ‘Fifty Shades of Grey.’

Emilia Clarke was offered the role of Anastasia Steele in last year’s Fifty Shades of Grey movie adaptation, but turned it down. Why would she turn down such a major movie role? The nudity! Clarke rejected the movie because it required nudity, which is something she had already done in Game of Thrones and in her Broadway debut.
“I’d done nudity before and was concerned with being labeled for doing it again,” Clarke recently told The Hollywood Reporter in an interview.
Clarke claims she has no regrets about turning down the movie, which ended up being a critical mess but a box office success.
 She Used to Work as a Licensed Real Estate Agent.

While she was a student at New York University, Clarke worked as a licensed real estate agent for two summers as one of her six jobs she was worked to pay the rent, according to an interview with Marie Claire. I would’ve purchased whatever house she was selling.
The Actress Only Had 24 Hours to Prepare for Her ‘Game of Thrones’ Audition.
Emilia Clarke only had 24 hours to prepare for her Game of Thrones audition. To prepare for the interview, she called in sick to her catering job and “Wikipedia-ed the crap out of it.” Four days after the interview, Clarke learned that she would star in HBO’s Game of Thrones as Daenerys Targaryen. Clarke discussed her Game of Thrones audition with Jimmy Fallon once, in which she mentioned that show runner David Benioff suggested she do a dance. Clarke’s response? She did the funky chicken which transitioned into the robot.
 She Auditioned for Sharon Carter/Agent 13 in ‘Captain America: The Winter Soldier,’ But Lost to Emily VanCamp.

Deadline reported that Clarke was one of five actresses whom tested for the role of Sharon Carter in Captain America: The Winter Soldier, but she was beat out by Emily VanCamp. Among the losing auditions were Downton Abbey’s Jessica Brown Findlay, Teresa Palmer, Imogen Poots and Alison Brie. If you ask me, Clarke would have made a bad-ass love interest for Steve Rogers.
 Clarke Was Voted #1 on Ask Men’s ‘Most Desirable Women of 2014′ List.

It’s not exactly the most impressive feat, but Clarke was voted the most desirable woman of 2014 by a poll on Askmen.com. This was her third year appearing in the yearly poll, in which she made her debut in 2013 at #88. That’s quite a major jump, wouldn’t you say?


London Born and Raised
Born on April 7, 1987, in London, England, Clarke attended the St. Edward's School in Oxford from 2000 to 2005, then went on to study at Drama Centre London from where she graduated in 2009. Her first role was in the British soap opera ""Doctors"" in 2009, but her interest in acting began at the age of three.



";

                showText1.Text = @"The Khaleesi Wig
Fans dont recognize Clarke without her Khaleesi wig. She is a brunette in real life. She told ""GQ"" in a recent interview that, ""It takes a die-hard fan to actually spot me. I keep asking to go out with the wig at night, but they insist there's no way. It's silly to say, but when I take the wig off at the end of the day, I'm rather disappointed when I look in the mirror.""

""Breakfast at Tiffany's""
""Breakfast at Tiffany's"" is a Broadway play that began its run in 1966. On March 20, 2013, Emilia Clarke began portraying Holly Golightly in the Broadway production of the play. Her performances ended on April 21, due to lagging ticket sales, but Clarke received high praise for her performance.

""Girls""
""Girls"" is an HBO comedy/drama series that follows a group of 20-somethings living in New York City, and it's a show Emilia Clarke absolutely loves. In her interview with ""GQ"" she said, ""I'd give my right arm to be, like, a random extra on Girls, just to walk past one of the scenarios.""

Emilia Clarke, the Musician
It's not hard to see that Emilia Clarke is a talented actress, but she is actually quite the musician, as well. Her musical talents include singing and playing the flute, piano, and the guitar. Unfortunately for her fans, she doesn't get the chance to use these talents on her hit show ""Game of Thrones.""

She Loves Daenerys
Clarke loves the character she plays on ""Game of Thrones."" In an interview with the LA Times, Clarke said, ""One of the many things I love about Daenerys from Game of Thrones is she's given me an opportunity to fly the flag for young girls and women, to be more than just somebody's wife and somebody's girlfriend."" She appreciates her character's softer side as well as her many strengths.

Emilia Clarke's Eyebrows
While many actresses on the Hollywood scene pluck or shape their eyebrows, Clarke learned a very important eyebrow lesson from her mother. In a recent interview she said, ""My mum had rules when I was growing up: Don't do drugs, don't have sex, and don't touch your eyebrows. So I got bullied as a kid for having ridiculous eyebrows. She said, 'You'll be thankful when you're older,' and I am.""

Clarke Wasn't the First Daenerys
In the original pilot for ""Game of Thrones,"" Tamzin Merchant, previously of ""The Tudors"" fame, won the role of Daenerys. The reason of the recast wasn't disclosed but the part of the mother of dragons certainly belongs to Emilia Clarke. Fans of the show and the character would probably agree that casting Clarke was the right decision.

Hot and Talented
As of July 2013, Clarke had her name placed on both the Victoria's Secret What is Sexy list and the Maxim Hot 100 List. Besides being eye candy for the guys in the audience, she also has tons of talent. In 2013, she received the BAFTA nomination for best supporting actress in a drama.
Emilia Clarke is the talented actress who portrays Daenerys, mother of the Dragons on the HBO series ""Game of Thrones."" She is a beautiful lady and has a lot of talent to offer.
";


            }

            else if (teamCounter==1)
            {
                showText.Text = @"Dinklage grew up in New Jersey, where his neighbor was Bruce Springsteen's manager. ""Bruce used to come over to his house and hang out and play guitar,"" Dinklage says.

His first film performance was in Living in Oblivion in 1995, in which he played a dwarf. The film also starred another current HBO standout, Steve Buscemi, who is a good friend of Peter.

Dinklage appears in two versions of the same film,Death at a Funeral. He plays Peter in the 2007 British comedy and Frank in the 2010 U.S. remake.

He and his director wife, Erica Schmidt, have collaborated several times, including an upcoming production of The Imaginary Invalid at Bard College.

Dinklage was first choice for author George R.R. Martin and the Game of Thrones producers for the role of Tyrion Lannister.

He is the only Game of Thrones cast member who isAmerican.

Lena Headey, who plays Cersei Lannister, was good friends with Peter before Game of Thrones. In fact, Peter suggested her for the role when talking to producers.

Although he's as badass as Tyrion Lannister, he does not enjoy the sword play acting he must do. He says, ""The fight scenes are all a big lie. The whole time, you're trying not to get hit in the eye with a sword, and you wish you had on a welding helmet.""

During his Golden Globes acceptance speech, Peter spontaneously mentioned Martin Henderson, who was partially paralyzed during a dwarf-tossing attack in Britain.

Charles Dance, who plays Tywin Lannister on Game of Thrones, says that he is constantly apologizing to Peter on set because he ""treats him appallingly"" when in character.

Peter Dinklage was James, the ""wake-up guy"" with the sexy voice on Seinfeld.

On his first day of college, Peter came dressed in tights and a woman's velvet cape.


";


                showText1.Text = @"Peter used to let his height bother him but has since gotten over it: ""When I was younger, definitely, I let it get to me. As an adolescent, I was bitter and angry and I definitely put up these walls. But the older you get, you realize you just have to have a sense of humor. You just know that it's not your problem. It's theirs.""

Peter suffers from achondroplasia, which impaired his arms and legs and had bowed his legs so badly he could barely walk, requiring doctors to break, reset and brace them with a bar.

Although he once said that he wanted to reach a point in his career where he could be the lead and ""get the girl,"" Dinklage is rethinking that. He says, ""Maybe I'll have to take that back. I like playing the guy on the sidelines. They have more fun.""

After college, he and his friend Ian Bell moved to Williamsburg with visions of building a theater company modeled on the famous Steppenwolf in Chicago.

Dinklage supports Farm Sanctuary and has served as the spokesperson for the organization's Walk for Farm Animals.
Peter supports Cruelty Free International, which is a global organization committed to ending cosmetic tests on animals. 
His favorite bar in L.A. is The Lava Lounge, which has since been shut down.

Before he gave his commencement speech at his alma mater Bennington College, a student handed him a mace five minutes before he was supposed to go out so he walked out with it in his hands.

Even as a starving actor, Peter refused to take parts as elves, leprechauns or anything that made him feel ""dirty."" As a result, ""I said no a lot,"" he confesses. ""A lot.""
 
Peter's family had a habit of collecting creatures that didn't always want to be pets and the first pet he can remember was a Lab named Zoe.

He and his brother did puppet shows for their neighborhood in New Jersey. He says, ""We basically did little puppet musicals with the loudest songs we could find. We did a puppet version of Quadrophenia, The Who album.""

Peter has been developing a script for years, basedon the life of the Fantasy Island star Hervé Villechaize, with his friend Sacha Gervasi, director ofAnvil!.

He has a scar that runs from his neck to his eyebrow due to an onstage accident when he was performing at CBGB in New York with his old band Whizzy.
";


            }


            else if (teamCounter == 2)
            {
                showText.Text = @"1. Named Christopher Catesby Harington, Kit was born in London in 1986.

He moved to Worcester when he was 11, and has a brother named John.
2. He’s secretly posh.

His ancestors include Sir Richard Harington, the 12th Baronet Harington, Henry Dundas, 1st Viscount Melville, and Sir William Molesworth, 6th Baronet.
 
3. His real name is Christopher, but nobody calls him that.

 “I was called Kit from day one, really, I only found out my name was Christopher when I was 11. I went to school, and I remember that you had to do these tests to find out what set you’re in—how clever you are. I put down ‘Kit Harington’ and they looked at me like I was completely stupid, and they said, ‘No, you’re Christopher Harington, I’m afraid.’ It was only then I learnt my actual name. That was kind of a bizarre existential crisis for an 11-year-old to have, but in the end I always stuck with Kit, because I felt that’s who I was. I’m not really a Chris.”
4. He got his big break in theatre.


Harington studied Theatre and Drama Studies at sixth form, and graduated from the Central School Of Speech And Drama in 2008.
5. And was the original lead in War Horse.

He won the role of Albert in the original stage version of War Horse while he was still studying, and played the character until 2009.
6. He turned up to his Game Of Thrones audition with a black eye.

 “I don’t remember what happened but it made me look a bit tougher than not having a black eye I guess,” he says. For his third audition, he read a scene from Season Three with Rose Leslie (Ygritte).
7. His foot was in a cast for most of Season 3 of Game Of Thrones.

Harrington shattered his ankle by climbing through a window when he’d lost his house keys. Game Of Thrones costume designer, Michelle Clapton explained: “He had a medical boot that he could take off, but he still couldn’t walk. We cut the back out of his [costume] boot so that he could put it on without having to actually step into it and just bound it to his leg. He managed really well, considering the amount of pain he was in”.
8. The injury meant Kit had a body double for some scenes in Season 3.


Kit found it hard to take. “Even if it was just somebody walking I had a problem not going up to the guy and telling him how to do things differently. You don’t think you create a walk for a character, but you [do].”
9. He’s not very good with public transport.

10. His ideal first date involves dinner, and wine.

 “You don’t want to seem too eager, too romantic - otherwise, it just looks a bit try-hard. But I do think that a first date should be intimate. So I’d choose a nice dinner somewhere cozy, not too crowded, with good wine.”

";


                showText1.Text = @"11. He’s a horror movie buff.

 ‘I’ve always wanted to do a horror movie. My favourite is The Shining, but I also loved The Ring, the Scream movies and The Wicker Man with Christopher Lee.”
12. He’s a big David Lynch fan.

 “I love [David] Lynch as well. I could not get through Inland Empire. I tried to watch that movie three or four times. I can’t get through it. It’s too scary. Starts freaking me out and then when it goes black and white … too much, too much. I’ve never even tried to watch Eraserhead. I think it would be too much for me. I love Mulholland Drive but even that kind of got to me at times.”
13. But he gets frightened by video games.


Despite appearing in Silent Hill: Revelation 3D, Kit isn’t fond of video games. “I’m not good at playing those things. I used to get terrified of Doom, and when I played this, I was pretty terrified of it. I’m a bit of a wimp when it comes to computer games.”
14. He can speak a little Icelandic.

Like, a really small amount. “It’s very difficult to say anything in Icelandic. I can say ‘takk’, which means ‘thank you’. That’s about all I learned. They’re all brilliant at speaking English, so it’s one of those problems that you don’t have any trouble communicating.”
15. He modelled his Northern accent on Sean Bean’s.

 “I auditioned for Jon Snow in my own accent, and then when we got to filming the pilot, they asked all of Sean Bean’s sons to do Sean’s accent, so we had to go and learn it quickly.”
16. He’s scared of flying.

 “Spiders, flying and injections” frighten Kit. “I’m turning into a flying alcoholic, because I can’t deal with it. My dad started taking flying lessons. He’s now got his solo flying thing, and he says, ‘You’ve got to come up in the air,’ and I’m like, ‘Not for s—-!’”
17. Game Of Thrones was the first time he had long hair.

 “I always had short hair before I did this, and then they went ‘Could you grow your hair and a beard?’ And I went, ‘Well, I’ve never grown my hair, and I’m practically pre-pubescent in the facial-hair stakes, but I’ll give it a go!”
18. You won’t find him on Twitter.

 “I’m not a tweeter, I’m afraid. I have to talk about myself enough in publicity and stuff that I don’t want to do it in my free time as well. Tweet about things, no, no thanks. It’s not for me, I’m afraid…”
19. He’s fine with the nudity in Game Of Thrones.

 “I think it’s one of those things … you take off your robe and there you are nude. And there’s a hundred people watching you and after the first 30 seconds, everyone’s seen everything. I’m quite happy to strut around naked after that.”
";



            }


            else if (teamCounter == 3)
            {
                showText.Text = @"1. Headey was born in Bermuda, where her father -- a Yorkshire police cadet -- was stationed. She grew up on the island country before her family moved back to Huddersfield, Yorkshire, when she was five.

2. Peter Dinklage and Headey were friends before ""Game of Thrones,"" prompting the actor to recommend the English actress for the role of Cersei Lannister.

3. She practices boxing and yoga in her free time in order to stay fit.

4. The actress was first spotted by a casting agent in a one-off show when she was 17 years old. Realizing the young woman's talent, the agent took a photo and asked her to audition. The chance encounter resulted in her getting cast in her first feature film, ""Waterland"" (1992), which co-starred Ethan Hawke and Jeremy Irons.

5. Headey dated ""The Jungle Book"" co-star Jason Flemyng (""Snatch"") for nine years and has a tattoo of his name in Thai on her arm.

6. She's an avid Twitter user and couldn't care less if she drunk tweets, saying, ""they're just these tiny words.""

7. The English actress had to learn how to skin a rabbit for her role in Terry Gilliam's ""The Brothers Grimm"" (2005).

8. She is a vegetarian and has campaigned against animal abuse with PETA.

9. Headey's only marriage was to Irish hairstylist/musician Peter Loughran in May 2007. The actress and Loughran have since split, but they have a young son together (Wylie, b. 2010).

10. She is friends with actress Piper Perabo, who she starred with in two films in 2005 -- ""Imagine Me & You"" and ""The Cave.""

11. The actress loves horror movies, saying they're a ""real escape"" and often very relaxing because she can get caught up in the fantasy of the film and just shut down for a minute.

12. One of Headey's female fans once approached her and showed the actress her ""300"" inspired wedding album, in which the bride dressed up as Headey's character, Queen Gorgo, for her special day.

13. She used a body double for her ""risque"" scene in ""Game of Thrones"" (that one between her and her onscreen brother...).

14. The actress has acknowledged she's terrified of appearing on talk shows.

15. She has two dogs, named Wizard and Angela Lansbury (of course).
";
            }


            else if (teamCounter == 4)
            {
                showText.Text = @"1. He’s Danish. Although he sports a very convincing British accent on GoT, Nikolaj was actually born in Rudkøbing, Denmark. Now that’s a great Dane!

2. He’s gone medieval before. Nikolaj played the role of “Village Sheriff” in the 2005 period piece, Kingdom of Heaven.

3. He met George Clooney in a bathroom stall. Not on purpose! Nikolaj thought the stall was empty, but instead found it to be very much in use by none other than George Clooney. If only stuff like that would happen to us!

4. He’s been injured on set. Nikolaj suffered a bruised rib during filming when he was kicked by Locke (Noah Taylor). Don’t worry though, the loss of his hand was just special effects!

5. He likes gangster movies. Nikolaj’s favorite movie is the1984 Sergio Leone film, Once Upon a Time in America. Somehow, it seems fitting. ";
            }


            else if (teamCounter == 5)
            {
                showText.Text = @"1.	He was born in California in 1956, to Peggy Sell – a radio actress, and Joseph Louis Cranston – a Hollywood actor and producer.
2.	Bryan’s parents didn’t want him to have a career in Hollywood, so Bryan Cranston didn’t start pursuing his acting career until he left college.
3.	He earned a two-year degree in police science, but he didn’t go into a law enforcement job after graduation. Instead, he and his brother took to the road on their motorcycles!
4.	Before Cranston hit the road with his brother, they worked as waiters in a Florida restaurant, at the time they left, the chef was murdered, which made Bryan and his brothers murder suspects for a while… We all know Bryan went full Heisenberg on him!
5.	Bryan Cranston is 5’10” tall (1.79 metres)
6.	At the age of 21 Cranston married Mickey Middleton, however the marriage ended in a divorce 5 years later. He went on to marry Robin Deardon, who he met on the set of Airwolf. They have a daughter named Taylor Deardon Cranston, who reads Theatre Studies at the University of Southern California. She was also an extra in an episode of Breaking Bad directed by Bryan Cranston.
7.	Bryan pockets $225,000 (£141,000) per episode of Breaking Bad, which means his earnings for the final eight episodes of the series is $1.8million (£1.1million)!
8.	In his early days as an actor, he was dubbing voices and doing several commercials, including one where he wore a skunk costume and took a shower… strange, but true!
9.	The actor is a baseball lover and a loyal supporter of the LA Dodgers. He collects memorabilia and even his wife had to throw his 40th birthday party at the Dodgers’ Stadium. In an Emmys acceptance speech, he famously revealed that that he loves his wife and daughter more than a baseball.
10.	Aside Breaking Bad, Cranston is renowned for his role as Hal, the father in the wildly successful sitcomMalcolm in the Middle. Hal lived in the shadow of his domineering wife, Lois, and had extremely camp tendencies such as rollerskating to Queen in a glittery disco suit. He claims this was his favorite episode to film, as he spent six weeks learning to roller-skate in advance.
11.	Bryan Cranston did voice-overs on Mighty Morphin’ Power Rangers. If you have a really good memory, or for some reason you still watch it, you’ll know the blue Power Ranger’s name was Billy Cranston. The team decided to name the character after the voice actor – so yeah, he’s kind of a Power Ranger!
12.	He has a dog called Sugar, who he once rescued.
13.	The Star Actor was honored as Grand Marshal at the 2006 Sherman Oaks Street Fair in California. The accolade was in celebration of his contribution to the local community and support of KidSmartz, an initiative to help prevent child abduction.
14.	Cranston is a creative gifter. He once wrote a screenplay and offered it to her as a birthday gift.
15.	Bryan Cranston will appear in the Breaking Bad spin-off series Better Call Saul.

";
            }


            else if (teamCounter == 6)
            {
                showText.Text = @"1. Paul auditioned for the role of Francis on ""Malcolm in the Middle"" (2000), the hit sitcom that starred his future ""Breaking Bad"" co-star, Bryan Cranston.

2. The ""Breaking Bad"" star was born Aaron Paul Sturtevant in Emmett, Idaho, on August 27, 1979.

3. His father is a Southern Baptist minister.

4. While at the Prince of Brunei's 25th-birthday party, Paul had an hour-long heart-to-heart with Michael Jackson and ended up taking shots with the legendary musician. And all before his ""Breaking Bad"" fame!

5. In 2000, the actor appeared on ""The Price Is Right"" as a contestant -- and he couldn't have been more psyched. Paul appeared in the Showcase round, but unfortunately overbid by just $132.

6. In order to afford the move to Los Angeles, Paul worked up to five jobs at a time, including Pizza Hut delivery boy and giant frog mascot for a radio station. After graduating high school, the aspiring actor drove out to LA with a few thousand bucks in his pocket.

7. In eighth grade, Paul knew he wanted to be an actor after taking his first real acting class.

8. His first film role was a supporting turn in ""Whatever It Takes"" (2000), which starred James Franco and Shane West.

9. Still trying to pave his way in Hollywood, Paul starred in music videos for the bands Korn(""Thoughtless"") and Everlast (""White Trash Beautiful"").

10. The actor married Lauren Parsekian in May, 2013, in a 1920s Parisian-carnival-themed wedding (his idea). The wedding took place in Malibu, California, with music by Foster the People and John Mayer.

11. Paul hosted WWE Raw in March, 2014.

12. In December 2013, it was announced that Paul's animated series ""BoJack Horseman: A Tale of Fear, Loathing and Animals"" will premiere on Netflix sometime in 2014.

13. He's known to surprise and introduce himself to tourists that drive by his residence in Hollywood. What a cool, humble guy!

14. Paul worked as a movie theater usher at Universal Studios in Hollywood prior to having success as an actor.

15. The actor has two Emmys (Best Supporting Actor) for his breakout role in ""Breaking Bad,"" opposite Bryan Cranston.

16. According to his Reddit AMA (Ask Me Anything), the biggest similarity between Paul and his ""Breaking Bad"" character, Jesse Pinkman, is that they both have a huge soft spot for kids and want to protect them.

17. The actor has acknowledged he's had limited formal acting training and never understood ""strange acting exercises."" His method is to simply pretend he's someone else and delve into the character completely.
";
            }


            else if (teamCounter == 7)
            {
                showText.Text = @"•	Raised in Santa Fe, NM, she once costarred in a 1997 film called Santa Fe, which starred Gary Cole and Lolita Davidovich. There's also a New Mexico connection with her TV series, Breaking Bad, which is set in Albuquerque.
•	Landed her first professional acting job, in The Beggar's Opera at the Court Theatre in Chicago, in 1990, while still an undergraduate at Northwestern University.
•	Made Broadway debut  the 1996's revival of The Rehearsal, which also starred Roger Rees.
•	Played Marie Curie in Radiance: The Passion of Marie Curie, a play written by Alan Alda, in 2011.

";
            }


            else if (teamCounter == 8)
            {
                showText.Text = @"‘It’s all good, man.’ – Some interesting facts about Breaking Bad character Saul Goodman and Bob Odenkirk, the actor who plays him.
DUI? Paternity Charge? Trouble with a couple of revenge-hungry assassins from a Mexican drug cartel hunting you? Then you better call Saul!
As all you Breaking Bad-ers out there will know, when you’re in trouble no man can help like Saul Goodman. And, of course, we all know that Saul can be the centre of certain troubles, with his very shady off-the-book dealings and the fingers he has in multiple illicit pies. You might not be surprised to finding that Saul Goodman’s name is derived from the saying ‘It’s all good, man’ – although it rarely is when you need to call Saul!
But what do we know about the man behind the role, Bob Odenkirk? Well there are many things that we know about him. His full name is Robert John Odenkirk, his birthday is the 22nd of October 1962. Odenkirk was born in Illinois, although his career was birthed through his work in a number of improv and comedy clubs in Chicago during the eighties.
In 1987, Saturday Night Live asked Odenkirk to come and be one of the writers for the show. Although prosperous for Odenkirk, Saturday Night Live proved to be the cause of some frustration for the then-young comic when he found himself behind the cameras more than he did in front of them. In 1991, Odenkirk leftSaturday Night Live, thus establishing himself as one of the more well-known names in TV-Comedy throughout the 1990’s.
Two of Bob Odenkirk’s TV appearances in the 1990s both feature him in parodies of Metallica‘s Enter Sandman video! He also featured in a cameo for Seinfeld. Odenkirk is one among six other Breaking Bad actors (some big and some small) who have had cameos or larger roles in Sienfeld including: Bryan Cranston (Walter/Heisenberg), Anna Gunn (Skyler), Jessica Hecht (Gretchen), Larry Hankin (Old Joe), Nigel Gibbs (Detective Tim Roberts) and Mark Harelik (Doctor). In 1995 Odenkirk teamed with comedy friend David Cross to co-create critically acclaimed HBO sketch-show Mr. Show with Bob and Dave. Odenkirk also went on to have several guest appearances on the TV shows Curb Your Enthusiasm, How I Met Your Mother and Arrested Development, before being cast by Vince Gilligan as Saul Goodman in 2009 on AMC’s award-winning showBreaking Bad.

";
                showText1.Text = @"In an interview with Terry Gross of Fresh Air, Bob Odenkirk revealed how he came to be Saul Goodman and a few things about the character he helped bring to Breaking Bad. In the interview Odenkirk says how when Vince Gilligan first told him the character’s name he protested, ‘I’m not Jewish. There are a lot of Jewish actors, I’m sure you could find one.’ Vince Gilligan laughed at this, telling Odenkirk (as Saul does to the viewer) how he is not Jewish but Irish, and uses this pseudonym to feel like a Jewish-lawyer extraordinaire, and not just some normal white guy.
In the interview with Gross, Odenkirk also revealed it was him who came up with the idea for Saul’s haircut! ‘It’s a comb-over that’s pretty clearly a comb-over, with a growing bald spot and yet at the same time somehow a mullet in back.’ Odenkirk then went on to describe why he thought this haircut suited Saul’s character so much: ‘Cleaned up on the sides, because he’s all business, and the comb-over is to try look younger, and the mullet is to try to look like a relaxed dude, but who’s also capable of focusing and being serious’. What do you think about this? Does Saul’s hair envisage all of these qualities to you? I’d say it definitely does!
Bob Odenkirk also told Fresh Air that he tried to base his performance on the Hollywood agents Robert Evans and Ari Emmanuel. Ari Emmanuel was also the inspiration for Jeremy Piven’s character Ari Gold in TV ShowEntourage, as well as the inspiration for another Bob Odenkirk character called Stevie Grant on The Larry Sanders Show. Ari Emmanuel is not only Bob Odenkirk’s acting inspiration, however, he is also Odenkirk’s actual agent!
Since Breaking Bad has ended, Odenkirk has written some sketches for a couple of TV shows including Adult Swim. In September 2013, it was announced that AMC had given the go ahead for a Saul Goodman spin-offBetter Call Saul. Vince Gilligan said ‘I like the idea of a lawyer show in which the main lawyer will do anything it takes to stay out of a court of law. He’ll settle on the courthouse steps, whatever it takes to stay out of the courtroom. That would be fun – I would like that.’
So what do you think? Will the Saul spin-off be a success? Will he be able to stay out of the courtroom? For now we’ll have to wait, but one thing is certain. Soon enough we’ll all be calling Saul!
";


            }


            else if (teamCounter == 9)
            {
                showText.Text = @"•If it weren’t for Linda’s menstruation he wouldn’t be here. Well, Linda’s Film on Menstruation, to be exact. This 18-minute film, in which a 27-year-old Banks plays boyfriend to a supposed 15-year-old during her first “leaky-time,” could probably be classified under the educational-horror genre. The droopy eyes, the slow drawl; it’s all there, unrefined but just as charming. Also, check out how much Banks looks like Frank Stallone.


•Jonathan banks likes yelling out of car windows. When his BB character, Mike, speaks through gritted teeth, you get the sense that you should probably do as he says. But check out this clip from Banks back when he played Frank McPike in the late 80’s TV show, Wiseguy. Who knew Mike had a set of pipes on him? And BTW, if you take the ‘cP’ out of McPike, guess what you get?

•He’s already been nominated for an Emmy. His wisecracking Frank McPike on Wiseguy was a precursor to his portrayal of Mike on Breaking Bad (Frank McPike is a policeman, Mike is a former policeman). Check out Banks speaking candidly about the show and its nuances in this 2009 interview.


•Banks does comedy too. He’s not just an actor on one Emmy-nominated show, he’s on two (Modern Family, Breaking Bad). Add that to the fact that Wiseguy also racked up Emmy nominations in the ’80s, and this guy is a TV show awards luck-charm.


•Banks’ mom was in the CIA. She was in it so deep that every so often, shadowy men would come and speak to his family’s neighbors. Hmm … could this be an elaborate angle cooked up by “Heisenberg”?

";
            }


            else if (teamCounter == 10)
            {
                showText.Text = @"1.	Her birth name is Jennifer Joanna Anastassakis. She later shortened her name to make it easier for people to remember it.
2.	Both her parents are actors and encouraged her high school interest in drama. her father, John Aniston, is best known for his role as Victor Kiriakis on the daytime drama Days of Our Lives. Her mother is Nancy Dow.

3.	She has royal blood in her. Through her mother, Jennifer is a direct descendant of the royal House of Stuart of Scotland.

4.	As a child, Aniston lived in Greece for a year with her family. They moved to Pennsylvania, then to New York City.

5.	Aniston attended a Waldorf educational school in New York when she was six and harnessed her love for acting at age 11 at the school.
6.	When she was 11, one of Jennifer's paintings was placed in the Metropolitan Museum of Art.

7.	In high school, Jen was known as a class clown.

8.	She went to school with Chaz Bono.

9.	Jennifer had worked as a waitress and telemarketer before making it as an actor.

10.	She also appeared as the Nutri-System girl on the Howard Stern show.

11.	Aniston made her screen debut in the television series Molloy (1990), but her film career began in the horror film Leprechaun (1993). The horror flick was a bad experience for her and actually made her consider giving up her acting career. Well, it's a good thing she didnt!

12.	She appeared in 'Tom Petty and The Heartbreakers' music video for the 1996 song ""Walls.""

13.	Her big break came when she was cast as Rachel Green in the NBC sitcomFriends.The hugely popular series made her a star and a household name.

14.	Jennifer originally auditioned for the role of Monica Geller on the show ""Friends,"" but persuaded producers that she was better suited to play Rachel Green. She got the role after she was told by the producers to lose 30 pounds. Ouch!

15.	Chris McMillan, who managed the 'Friends' star's hair for more than a decade, admitted he was stoned when he cut Jennifer Aniston's into the iconic ""Rachel"" haircut.

16.	Her best friend is her Friends co-star Courteney Cox.

17.	She won both a Golden Globe and an Emmy Award during her tenure on the show.

18.	She went on to star in 238 episodes of the hit series, becoming one of the highest paid actresses in a television show at $1 million per episode.

19.	Jennifer offered to be Matthew Perry's personal trainer in 2002 to help him lose weight.
20.	She has a fear of flying - even though she has to do it so often for her work.

21.	Jennifer was once recognized by a fan when she was naked in a sauna. How's that for an awkward moment?

22.	Jen met her future husband Brad Pitt met on a blind date in 1998. The couple got married in 2000.

23.	Jennifer refused to invite her mother to her wedding to Brad Pitt after she insulted Jennifer in the tabloids. They made up in 2005.
24.	Brad Pitt appears in one episode of Friends in season 8 called ""The One with the Rumor."" He acts as Will, a friend of Ross who is in town for Thanksgiving. It turns out that Will and Ross had a secret ""I hate Rachel"" club in high school which makes for great comedy since they were still happily married at the time.


";

                showText1.Text = @"25.	Made a skit satirizing Brad Pitt's stalker, Athena Marie Rolando, when hosting ""Saturday Night Live"" in 1999.

26.	Jennifer is the first woman to win the GQ Man of the Year award. She shared the award with 50 Cent and Vince Vaughn in November 2005.

27.	While filming Mr. & Mrs. Smith with Angelina Jolie, Brad Pitt is rumored to have fallen for her while still married to Jennifer. Although the couple denied anything romantic happened until Jennifer and Brad got divorced in 2005.

28.	She stays in great shape by practicing yoga. She filmed the introduction for her instructor's 2009 Yogalosophy DVD.

29.	The late actor Telly Savalas was her godfather.
30.	She is 5' 6"" (1.68 m) tall.

31.	However, this sexy actress was not alone for long. She dated actor Vince Vaughn, singer John Mayer and SNL cast member Jason Sudeikis following her divorce from Brad Pitt.

32.	Jennifer Aniston's ex-boyfriend John Mayer said that Jen was confused by Twitter and that it was one of the reasons they eventually parted ways; however, the actress later said she should join Twitter so she could use it to dispel rumors.
33.	Her favorite color is blue.
34.	She began dating Justin Theroux in 2011 and the couple got engaged August 2012. Aniston and Theroux met while filming Wanderlust.
35.	Jennifer owns a Welsh corgi-terrier mix named Norman and a white german shepherd named Dolly.

36.	Her birthday is February 11, 1969 and she shares it with Mike Shinoda of Linkin Park, Burt Reynolds, Sheryl Crow, and Kelly Rowland.
37.	She dislikes spicy foods also Greek, Chinese, and Indian food, but is very fond of Mexican food.

 
38.	Her favorite movies include ""Wuthering Heights"" and ""Fame.""

39.	She is the godmother of Coco Riley Arquette, the daughter of Courteney Cox and David Arquette.
40.	If Jennifer wasn't an actress she has said that she would have been a therapist today.

41.	She is widely known for her beautiful locks, but before all that, she used to keep a tiny pair of scissors in the glove compartment of her car so she could trim any split ends when she found them.

42.	What does she dislike to read about her? ""Try that Jennifer Aniston diet."" There is no secret diet - she says she follows a healthy diet and exercises often.
";



            }


            else if (teamCounter == 11)
            {
                showText.Text = @"1.	His full name is Matthew Langford Perry. He spent his childhood in Canada after his parents got divorce.

2. The top part of his right middle finger is missing since his grandfather accidentally closed a car door on his finger.

3. He actually dated Yasmine Bleeth in 1996-97.

4. He himself is quite funny. He was the only person among 6 main leads of F.R.I.E.N.D.S who was allowed to sit with the writers.

5. He was addicted to alcohol and drugs. He himself confessed, "" I did and I felt better than I ever felt in my entire life. I had a big problem with pills and alcohol, and I couldn't stop.""

6. His father, John B. Perry, was a guest star on F.R.I.E.N.D.S playing the father of Rachel's boyfriend Joshua in ""The One With Rachel's New Dress"".

7. Chandler was written as a character who was awkward around women because Matthew Perry told producers that he himself was.
8. Matthew is a supporter of the Lili Claire Foundation and has acted as  host for their benefits
9. Matthew loves the Toronto Blue Jays, Ottawa Senators, and LA Kings
1o. Matthew played Chandler Bing for 10 years on the hist show “Friends”
11. Matthew’s favorite song is “Don’t Give Up” by Peter Gabriel and Kate Bush
12. Matthew’s favorite beverage (which he says he drinks way to much of) is Sugar Free Red Bull



";

                showText1.Text = @"13. Matthew’s favorite movie is Ground Hog Day
14. Matthew’s favorite video game is Halo once played it so much he injured his thumbs!
 15. Matthew became part of a video game when he voiced a character in the video game Fallout New Vegas
16. Matthew has been very good friends with actor Hank Azaria since the mid 80’s
17. He made is stage debut in London in the  play “Sexual Perversity in Chicago” in 2003
18. Matthew lost part of his middle finger in preschool after an accident with a door.
19. His father John Bennett Perry was the Old Spice Guy in the 70’s
20. Matthew has 4 younger sisters and 1 younger brother
21. Matthew grew up in Canada and has duel citizenship Canada and the USA
22. Matthew is an avid tennis player and once considered playing professionally before becoming an actor
23. Matthew loves the show “Lost”";



            }


            else if (teamCounter == 12)
            {
                showText.Text = @"1. Before he was known as Joey on ‘Friends’ Matt was a regular feature on US television as ‘that guy from the Heinz ketchup commercial’. In 1987, Matt starred in an advert for the brand which used the ‘good things come to those who wait’ slogan. The advert was incredibly successful and went on to win one of the world's most prestigious advertising awards, a Gold Lion at the Cannes International Advertising Festival.
2 When ‘Friends’ ended, Leblanc was the only cast member to receive his own spin off series, ‘Joey’ which ran for two seasons. But ‘Joey’ wasn't Matt’s first spin off. In 1991 he starred in ‘Top of the Heap’ a spin off of sitcom ‘Married With Children’, on which he had appeared as a boyfriend of Kelly Bundy. Matt starred as Vinnie Verducci, but the series  lasted for only seven episodes before being cancelled. The character was then given another spin off ‘Vinnie and Bobby’ which also ran for just seven episodes.
3. For Matt, landing the role of Joey on ‘Friends’ was more than just a lucky break. Although he’d eventually go on to earn over $1 million per episode on the series, when Matt got the part of Joey he was down to his last $11. When the now employed Matt got his first 'Friends' pay check, the presumably hungry actor was finally able to treat himself to a hot meal to celebrate. 
4. In 2003 Matt married model Melissa McKnight and a year later their daughter Marina was born. After she began suffering seizures at just eight months old, Marina was diagnosed with a rare brain disorder. Thankfully Marina has since outgrown the condition and although Matt and Melissa are no longer together, the actor remains close to his daughter, with the couple sharing custody of the now 10 year old.
5. Matt has recently revealed that he hasn't spoken to his father years, after he sold numerous stories about his son to the tabloids. Matt has said that growing up he had good relationship with his father despite their first meeting taking place when Matt was eight years old. However in recent years the father and son’s relationship has soured with Matt telling the Times, the two “don't really speak any more,” after he sold stories about the actor to various tabloids. 

";
            }


            else if (teamCounter == 13)
            {
                showText.Text = @"Born on his mother's birthday.
Graduated from Northwestern University.
Along with best friend & fellow actor Joey Slotnick, he helped found the Looking Glass Theater Company, based in Chicago, Illinois.
Before ""Friends"" (1994) Schwimmer competed against high-school friend Jonathan Silverman and actor Jon Cryer for a role in the TV pilot Couples (1994) (TV). Silverman won the role opposite Helen Slater, but ABC passed on the show. The producers later reconceived the show for singles and sold it to NBC as ""Friends"" (1994) in which Schwimmer was the first actor to be cast.
Called up a London talk show to deny false claims that cast members of ""Friends"" (1994) were demanding $1,000,000 each per episode. [April 2000]
Has worked extensively on the stage both as actor and director
Is on the board of directors of the Rape Foundation for the Rape Treatment Center of Santa Monica
Split up from Mili Avital in November 2001
Member of Delta Tau Delta International Fraternity
January 2003 - Premiered his play ""Turnaround"" at the 99-seat West Hollywood Coast theater. All of his ""Friends"" were in attendance.
He graduated Beverly Hills High School in 1984 and performed in stage productions there under the direction of John Ingle.
Went to the same High School as Angelina Jolie, Michael Klesic, Nicolas Cage, Lenny Kravitz, Jonathan Silverman, Gina Gershon, Rhonda Fleming, Jackie Cooper, Rob Reiner, Antonio Sabato Jr., Pauly Shore, Michael Tolkin, Betty White, Corbin Bernsen, Elizabeth Daily, Albert Brooks and Crispin Glover.
Both his parents, Arlene Coleman-Schwimmer and Arthur Schwimmer, had small parts in Since You've Been Gone (1998) (TV), which he directed.
David once said in an interview, he would like to become a public school teacher after ""Friends"" (1994) ended.

";

                showText1.Text = @"Has an older sister, Ellie Schwimmer.
Playing Michael in The Wonder Years, he rides a 500cc Triumph Daytona motorcycle. The same motorcycle, also seen in other episodes, is also seen mounted on the back of his character's Volkswagen van.
He is related to ""So You Think You Can Dance"" (2005) contestants Benji Schwimmer, Lacey Schwimmer & Heidi Groskreutz-Burns.
Ate only lox and bagels from Cassels Market in Margate, during the filming of Duane Hopwood (2005).
Was originally going to direct ""The Persuaders"" (2009) with George Clooney and Hugh Grant in the lead roles but the movie got scrapped.
Was so busy filming The Pallbearer (1996) that he missed Lisa Kudrow's wedding.
Turned down Ben Affleck's role in Chasing Amy (1997).
Turned down Will Smith's role in Men in Black (1997).
Allergic to cats.
Revealed that he had conflict with writers and cast members of ""Friends"" (1994).
He was awarded the 1991 Joseph Jefferson Award Citation for Director - Play for directing a stage adaptation of ""The Jungle"" at the Lookingglass Theatre Company in Chicago, Illinois.
Joy Gregory and he were nominated for a 2003 Joseph Jefferson Award for New Adaptation for ""Race: How Blacks and Whites Think and Feel About"" at the Lookingglass Theatre in Chicago, Illinois.
Lives in Los Angeles, California.
Became good friends with John Krasinski during the filming of Duane Hopwood (2005). Schwimmer attended Krasinski's July 2010 marriage to Emily Blunt.
With Andy Bellin, nominated for a 2010 Joseph Jefferson Award for New Work - Play for ""Trust"" at the Lookingglass Theatre in Chicago, Illinois.
David and his wife Zoe Buckman had their first child, a daughter named Cleo Buckman Schwimmer, on 8 May 2011. [May 23, 2011].
His wife Zoe Buckman gave birth to their daughter Cleo Buckman Schwimmer in New York (8 May 2011).
";



            }


            else if (teamCounter == 14)
            {
                showText.Text = @"1. Every time I go out, someone says, ""Hi, Phoebe!""
2. I'm not fluent in any foreign language, but I know a little Turkish because I had a Turkish boyfriend in college.
3. I used to play piano.
4. I used to be good at tennis, too, but when I'm not working, doing nothing is more appealing than a hobby.
5. If All About Eve is on TV, I can't turn it off!
6. I had my best vacation on an island in Fiji.
7. My son is 13, and he's never watched anything I've done. His taste leans more toward South Park than Romy and Michelle.
8. I have a toy poodle called Woolly.
9. I love cats too, but everyone in my family is allergic.
10. If I'm not smiling, I look like I'm miserable.
11. I love to bake chocolate chip cookies.
12. I don't remember specific episodes of Friends. If I watch one, I'm thrilled because it's a surprise!
13. My first job was as a department store security guard.
14. My show Web Therapy is all improv.
15. My husband and I have been married a long time and we're really happy -- but we can't play backgammon. We're too competitive.
16. When I researched my family for Who Do You Think You Are, we discovered relatives in Poland.
17. Kellan Lutz starred in my show The Comeback. He's adorable!
18. I studied biology and neuroscience.
19. Six months after college, I decided to give acting a real shot.
20. I love taking walks to stay in shape.
21. I'm really into books on tape.
22. There's nothing fun about karaoke to me.
23. I can't stop watching The Real Housewives of New York City.
24. It's hard to watch myself on screen.
25. I'm a homebody.



";
            }


            else if (teamCounter == 15)
            {
                showText.Text = @"1.	Her full name is Kaley Christine Cuoco.
2.	Kaley Cuoco was born on November 30, 1985.
3.	She resides in San Fernando Valley, California.
4.	She is 5’7″ tall and weighs 120lbs.
5.	She owns some property in the San Fernando Valley.
6.	She is a big fan of Taylor Swift.
7.	Since the seventh grade, Kaley has been home schooled as she didn’t like private school.
8.	She earned her High School Diploma at the age of 16.
9.	She once dated actor Kevin Zegers.
10.	She has a small tattoo on her lower back; it is of the symbol for faith.
11.	Kaley Cuoco loves dogs, and currently has a German Shepherd named Duke.
12.	She is most well-known for her part as Penny on The Big Bang Theory, and Billie from the last season ofCharmed.
13.	A majority of the clothes in Kaley Cuoco’s closet have never been worn, she just enjoys having them.
14.	She feels that she has an eye for bargains and she considers herself a good shopper.
15.	In order to relieve her stress, she likes to have a relaxing bath.
16.	Out of all the important people in her life, She idolises her grandfather the most.
17.	Her celebrity crush is Michael Vartan.
18.	One of her favourite television shows is Whose Line Is It Anyway.
19.	Her first job was in the modelling industry, she started her first job when she was around six years old.
20.	She loves to go bowling.
21.	Her favourite designer is Gucci.
22.	She takes a kickboxing or a spinning class three times a week.
23.	Her favourite lip gloss is Rosebud Salve.
24.	She is a big fan of Britney Spears.
25.	Her parents names are Gary Carmine Cuoco and Layne Ann Wingate.

";
            }


            else if (teamCounter == 16)
            {
                showText.Text = @"1.	His name is James Joseph Parsons.
2.	He was born on the 24th March, 1973.
3.	Jim was born and raised in Houston, Texas.
4.	He is the oldest of two children.
5.	He is most well-known for his role as Sheldon Cooper in The Big Bang Theory.
6.	Ever since his very first pay, as a bird, at school, he had a passion for acting.
7.	He attended Klein Oak High School in Spring, Texas.
8.	After graduating from high school, Jim received an undergraduate degree from the University of Houston.
9.	During his 3 years at University, he appeared in 17 plays!
10.	He later enrolled in graduate school at the University of San Diego in 1999 and graduated in 2001.
11.	His favourite show growing up was Three’s A Crowd.
12.	Jim is a big fan of American Idol, Lost and Grey’s Anatomy.
13.	Currently Jim lives in Los Angeles.
14.	Jim loves to play the piano.
15.	He is also a big fan of tennis, baseball, and basketball.
16.	Parsons is currently engaged to Todd Spiewak.


";

                showText1.Text = @"17.	Jim is 6’2 tall.
18.	He often panics the day before taping The Big Bang Theory, as he is worried that he will forget his lines.
19.	Jim’s favourite character on The Big Bang Theory is Penny.
20.	His mother and sister are both teachers.
21.	His father was the president of a plumbing company, but sadly passed away in a car accident in 2001.
22.	Jim’s nickname, (apart from Jim!) is Jimmy Pea.
23.	In 2010, Jim won an Emmy Award for an Outstanding Lead Actor in a Comedy Series for his part on The Big Bang Theory.
24.	In an interview, Jim said that The Big Bang Theory has changed his life.
25.	During the filming for the show, he often encounters a lot of references to scientific things, and many jokes from Sci-fi films. He has said in many interviews that he has to do research into each of these things to find out what they mean! He has also said that he has never seen Star Trek!
26.	Jim was voted friendliest in his high school graduating class. Awwh!
27.	He is good friends with co-stars Simon Helberg and Kaley Cuoco.
28.	Parsons’ zodiac sign is Aries.
29.	Has appeared in 15 failed TV pilots.
30.	In May 2012, Jim Parsons is scheduled to appear on Broadway as “Elwood P. Dowd” in a revival of Harvey.";



            }


            else if (teamCounter == 17)
            {
                showText.Text = @"1.	His full name is John “Johnny” Mark Galecki.
2.	Johnny was born on 30th April, 1975 in Bree, Belgium.
3.	His star sign is Taurus.
4.	Johnny’s father, Richard, was serving in the U.S. Air Force when he was born.
5.	His mother is called Mary Lou Galecki.
6.	He has one brother called Nick and one sister called Allison.
7.	He is pescetarian, which is basically a vegetarian but eats fish and seafood.
8.	At the age of 10, his parents refused to allow him to have his ear pierced.
9.	Johnny Galecki lived on his own in Burbank, California by age 14.
10.	He dropped out of school after the 8th grade.
11.	His first acting job was a little known sitcom called American Dreamer.
12.	Galecki had a small role alongside Ben Affleck in the movie Bounce. His character was called Seth.
13.	Johnny Galecki is more famously known for playing the character of Leonard Hofstadter on The Big Bang Theory.
14.	His character Leonard, is an experimental physicist with an IQ of 173.
15.	Galecki does not actually wear glasses. In The Big Bang Theory his glasses are only the frame, without lenses.
16.	He secretly dated actress Kaley Cuoco for two years.
17.	Johnny found a dog in a box in 2009, he named the dog Vera and has looked after it ever since.
18.	He is a good artist and loves to paint and sketch.
19.	Galecki’s favourite brand of cigarettes are Parliament Light.
20.	Johnny owns a log cabin in Santa Margarita, California. Where he owns 360 acres of land!

";
            }


            else if (teamCounter == 18)
            {
                showText.Text = @"1.	Simon’s full name is Simon Maxwell Helberg.
2.	He was born on 9th December 1980.
3.	This means that his star sign is Sagittarius.
4.	According to the Chinese Calendar, he was born in the Year of the Monkey.
5.	Simon was born and raised in Los Angeles, where he currently lives.
6.	He is an accomplished pianist and said he was really, really obsessive about playing piano in high school.
7.	He is currently married to actress Jocelyn Towne.
8.	He attended New York University’s Tisch School of the Arts where he trained at The Atlantic Theatre Company.
9.	Simon obtained his black belt in Karate when he was just 10-years-old!
10.	He started acting in 1999, taking guest roles and small parts.
11.	Simon is the son of actor Sandy Helberg and casting director Harriet B. Helberg.
12.	He is 5’4″ tall.
13.	Simon Helberg is most well-known for his role as Howard Wolowitz in the CBS sitcom The Big Bang Theory.
14.	He got his first role when he was 19 – as an extra in the comedy Mumford.
15.	He attended middle and high school at the Crossroads School in Santa Monica, California.
16.	Simon is expecting his first child with Jocelyn Towne in Spring 2012.
17.	Simon was raised in Judaism.
18.	He has recently bought Charlie Sheen’s Mediterranean mini mansion for $2.9 million!
19.	In 2007, he made a pilot for his own series entitled Derek and Simon: The Show.
20.	Simon’s Twitter profile is @SimonHelberg

";
            }


            else if (teamCounter == 19)
            {
                showText.Text = @"1.	Kunal Nayyar was born on 30th April 1981.
2.	His star sign is Tauras.
3.	He is a London-born, Indian actor. He was raised in New Delhi.
4.	He is currently married to Neha Kapur, who was Miss India 2006!
5.	He attended St Columba’s School in New Delhi, India.
6.	Kunal graduated from the University of Portland in Oregon, US with a B.S. in Business.
7.	He also has a Master’s in Fine Arts from Temple University, Philadelphia, PA.
8.	Nayyar debuted on screen in 2004, playing a bit role in the romantic comedy S.C.I.E.N.C.E.
9.	He is 5’8″(1.73 m) tall.
10.	Kinal Nayyar is most known for his part as Rajesh Koothrappali Ph.D, a physicist on the series The Big Bang Theory.
11.	He was born in London to a Punjabi family and moved to India when he was just four years old.
12.	He first gained attention in the US for his role in the West Coast production of Rajiv Joseph’s 2006 playHuck & Holden.
13.	In 2011, Kunal co-hosted the “Tribute to Nerds” show with co-star Simon Helberg at Just For Laughs comedy festival.
14.	He has won Mark Twain Prize for Comic Brilliance in American College Theatre Festival.
15.	He played Youssef Zidan, an Iraqi terrorist on the CBS drama NCIS (Naval Criminal Investigative Service).
16.	Kunal began acting in musicals and plays at a very young age.
17.	He played badminton for his school team and competed at state level in the region of North India.
18.	Kunal is also a massive fan of cricket.
19.	He currently lives in Los Angeles.
20.	Nayyar is currently writing his first feature film, and his critically acclaimed play, Cotton Candy, continues to run in New Delhi.
21.	According to Nayyar, his name means “one who sees beauty in everything” and it comes from a Himalayan bird known as the Painted Snipe.
22.	He plays the role of “Gupta” in Ice Age 4: Continental Drift.
23.	In an interview, Kunal has said that he is not too different from his television alter ego, Raj Koothrapali.
24.	He is afraid of heights.

";
            }


            else if (teamCounter == 20)
            {
                showText.Text = @"1.	Sofía Margarita Vergara Vergara was born July 10, 1972 in Barranquilla, Atlántico, Colombia. Her mother, Margarita Vergara Dávila de Vergara, is a housewife, and her father, Julio Enrique Vergara Robayo, produced cattle for the meat industry.

2.	Growing up, she attended a private bilingual Spanish/English school, known as Marymount School Barranquilla.
3.	Sofia was discovered at 17 by a photographer on a Colombian beach.
4.	Vergara was raised Catholic, and her religious beliefs were sometimes in conflict with her modeling and acting successes.
5.	She soon lands several gigs, including a starring role in a Pepsi commercial. She used the money she earned to support her family.
6.	Vergara was ""apprehensive about doing her first television commercial-until her Catholic school teachers gave her their personal permission to take the assignment.""
7.	She got married at 18 to Joe Gonzalez, and had her first and only child at 20. Her son Manolo was born in 1992.
8.	Sofia named her son Manolo after Steven Bauer's hunky character in the 1983 masterpiece Scarface.
9.	Unfortunately, the marriage didn't work and they divorced a year later and she went on to study pre-dentistry at a university in Colombia for three years.
10.	She got her big break on the Mexican telenovela ""Acapulco, Cuerpo y Alma"" in 1995.
11.	Vergara became a household name in Latin America when she co-hosted Univision's Spanish travel show ""Fuera De Serie ""from 1995-1998. The show took Vergara and co-host Fernando Fiore to various exotic locations.
12.	Her nickname growing up was 'La Toti'.
13.	She has also been thin and admits that when she was younger, she would wear two pairs of jeans to give the illusion of a fuller body.
14.	After Vergara's older brother Rafael is murdered in Bogotá, she and her family relocate to Miami, where Vergara becomes a star as host of Univision's Spanish-language game show A que no te atreves (""I Dare You"").
15.	In 2000, Sofia Vergara was diagnosed with thyroid cancer and undergoes surgery to have a thyroid gland removed. ""When they tell you that you have cancer, you panic,"" she told Self in 2010. ""Now I'm in remission, and the scar doesn't bother me. After the surgery in 2003, I had my son Photoshop a Frankenstein scar on my neck and sent it to my friends and said, 'I'm fine, I look perfect!' It was really funny.""
16.	In 2003, she dated singer Craig David for a few months.
17.	She began dating Tom Cruise after meeting at a party hosted by Jada Pinkett Smith in 2005, but the relationship didn't last long.
18.	Not surprisingly, she is close friends with singer Shakira. They were both born in the same town of Barranquilla, Colombia.
19.	After moving to the United States, she says she stopped eating meat because she says it tastes peculiar compared to Columbia.
20.	In 2002, she was a spokesperson for Miller Lite and even appeared in a Spanish-language commercial for them.
21.	She starred in the Spanish-language adaptation of Desperate Housewives-When the series premiered in 2007, Vergara played the Mary Alice Young role in"" Amas de Casa Desperadas.""
22.	In 2009, she gave her first Broadway performance as Mama Morton in Chicago. ""Ordinarily, more mature, matronly women are traditional Mama types,"" director Walter Bobbie tells the Miami Herald. ""But at the core, she's both warmhearted and tough. Sofia brings that.""
23.	She hits the jackpot after she's cast as Gloria Delgado-Pritchett on the ABC sitcom Modern Family, which costars Ed O'Neill as her husband and Rico Rodriguez as her son.
24.	Ironically, she said when she was growing up, she would watch Spanish dubbed ""Married With Children"" which starred Ed O'Neill as Ted Bundy. She said she was already a huge fan of the actor.

";


                showText1.Text = @"25.	Vergara earns Emmy, Golden Globe and SAG Award nominations for her laugh-out-loud role on Modern Family. She was nominated for the Primetime Emmy Award for Outstanding Supporting Actress in a Comedy Series for 2010, 2011, 2012 and 2013.
26.	She has not had a single ounce of work done on her, she is all natural. ""Maybe when I'm 45, I'll think about it,"" said Vergara.
27.	The curvy star's bust size is 32F and has had custom tailored dresses ever since she was young.
28.	Sofia wanted a breast reduction as a child, but now she is grateful for her voluptuous chest.
29.	She is 5' 8"" tall.
30.	Some believe her accent is fake which really surprise her. ""I go out to a mall or restaurant and when somebody hears me they'll go, 'Oh my God, it's your real accent.'"" Vergara admits that she lays it on a bit stronger for her character Gloria Pritchett in ""Modern Family.""
31.	In 2011, Vergara was supposed to star in The Paperboy, an independent drama directed by Lee Daniels. When shooting was delayed for a week (which conflicted with Vergara shooting Season 3 of Modern Family), she was forced to drop out.
32.	One of her favorite things to do in her free time is to read. ""I can read like crazy. I can sit down and read for four hours straight. I read up to three-four books a month.""
33.	Her natural hair color is blonde! She was advised to dye her hair so she could look more Latin. ""It was ignorance: They thought every Latin person looks like Salma Hayek,"" she said.
34.	Sofia appeared in a ""Got Milk"" print ad with her son, Manolo.
35.	She is currently dating Nicholas (Nick) Loeb, who is a businessman and has expressed interest in running for a Florida Senate seat.
36.	The couple got engaged on July 10, 2012.
37.	In 2011, she was named as one of the new faces of CoverGirl. She's featured in a series of ads including hilarious ones with fellow CoverGirl, Ellen DeGeneres.
38.	She has her own clothing line,The Sofia Vergara, which is available at the retail outlet K-Mart. The stunning beauty said she aimed to make her sexy looks affordable with the retail line.
39.	She has been named one of People magazine's ""50 most beautiful people"" and has been recognized by both the Hollywood Reporter and Billboard as one of the most influential Latinas in Hollywood.
40.	She gave Miley Cyrus a run for her money when she got down and twerked at the Emmy's ceremony in 2013. She said ""Check it out Miley"".
41.	Its customary to bring a date to the Emmy's or any award show, but Sofia bought tickets for 21 of her family members to attend the event in 2013.
42.	She loves an occasional Big Mac from McDonald's and has already been featured in four ads for the fast food giant.
43.	Sofia's favorite actors are Marlon Brando, Al Pacino, and Robert De Niro
44.	Vergara currently resides in Los Angeles, California with her son, Manolo.
45.	For the past two years, Sofia Vergara has been named by Forbes as the highest-earning actress on American TV. Over the past year alone, she made about $30 million.
";




            }


            else if (teamCounter == 21)
            {
                showText.Text = @"1. I am not a cat person.
2. I could live on Fresca.
3. Backgammon and gin rummy are the greatest gifts my father gave me.
4. I have tried and failed to learn Spanish for three years.
5. I doubt myself as a mother every day, but I love my boys [Oliver, 4, and twins John and Gus, 23 months].
6. Men drenched in cologne make me gag.
7. I secretly wish I were a cool barfly with a wicked pool game. I am not.
8. I’m a sucker for '70s music and anything with a cello.
9. I know the words to every Schoolhouse Rock! song.
10. I was really proud when Angela Bassett referred to me as ""the right white girl"" for Jumping the Broom [out May 6].
11. The people I work with on Modern Family are so ridiculously talented that I feel intimidated.
12. I hate voice mail.
13. I go to bed early, but I wake up in the middle of the night and read for an hour or two.
14. As a kid, I worshipped Jodie Foster in Bugsy Malone.
15. I don't understand cool cars, but wish I did.
16. I love basketball, but I cannot catch a ball.
17. I can't sing or dance to save my life.
18. Running is the only athletic endeavor I've ever been good at.
19. I am in awe of my sisters.
20. I'm not afraid to pick up a hammer and nail. In fact, I'm partnering with the Maxwell House Drops of Good project to revitalize struggling community centers across America.
21. I love a bargain and get ridiculously excited about shoes on sale.
22. I fall asleep on the couch. A lot.
23. I don't trust mean girls.
24. I get unnaturally excited about the Sunday New York Times.
25. I label anything without a heartbeat. It gives me a (totally false) sense of control.

";
            }


            else if (teamCounter == 22)
            {
                showText.Text = @"1. I love to cook. 
2. I'm not great at it. 
3. My wife, Holly, is an amazing cook, so everything around what I make tastes great. 
4. My hearing is awful. 
5. I fancied myself an athlete when I was young, until I actually got around athletes. 
6. I drive a '65 VW Beetle. 
7. I have the strength of 10 very large women. 
8. I once spent a summer camping in Alaska and working at a local fishery. 
9. I also spent a summer being an absolutely terrified forest firefighter. 
10. I used to be 6 feet tall. 
11. I love my job. 
12. I'm terrible at math. 
13. I'm also known as Joaquin Phoenix. Maybe you've seen me in some stuff. 
14. I went to the University of Oregon long enough to get a master's degree and didn't even earn a bachelor's degree. 
15. I would never shave if I didn't have to. 
16. I'm a horrible multitasker, so I email everything in bunches at the end of the week (including this list). 
17. I'm a huge sports fan. 
18. I enjoy fly-fishing. 
19. I'm a terrible fly-fisherman. 
20. My grandmother started several homes for abused women. 
21. My mother used to drag race competitively. 
22. I grew up in Oregon, right near the Applegate River. 
23. And I passed the bulk of my childhood in a small rural town. There were about 200 people. 
24. My two daughters love to jump on me like a trampoline, and it hurts.
25. I love it when my daughters jump on me. 



";
            }


            else if (teamCounter == 23)
            {
                showText.Text = @"1. He Plays Cameron Tucker on Modern Family

2. He’s from Kansas City

Not only that, but when he was young he wanted to be a clown and at the age of 9 created the clown character “Fizbo” — a recurring character he brings to life from time to time on Modern Family.
3. He Was a Pig Farmer
Graduating from Piper High School and Kansas State University in 1996, Stonestreet spent his early years on a family farm before making the leap to showbiz.
4. He Planned to be a Prison Administrator
While studying to be a prison administrator, Stonestreet tried out for the play Prelude to a Kissand unwittingly launched his acting career. Though cast in the smallest role in the play, he was “bitten by the bug” and began taking his career as an actor seriously.
5. It’s His Second Emmy in a Row
First receiving an Emmy in the 2011 awards, Stonestreet came back for a second year in a row to collect an Emmy for his role in Modern Family.
6. He’s Not Really Gay
Jokingly referring to himself as “openly straight,” Stonestreet has made a reputation for himself as one of the mostly openly gay people on Modern Family. In real life, though, he is absolutely not and actually models his character on Modern Family after his mother.
7. He’s a Huge Hockey Fan
Stonestreet is a die-hard L.A. Kings Fan. He also plays the drums, loves driving and nature and is an amateur photographer. He brings his drum savvy to Modern Family, showcasing his skills as a “fill-in drummer.”
8. He’s Been on Dharma & Greg, Malcolm in the Middle, Party of Five, Spin City, ER, The West Wing, American Dad, Providence, Close to Home, Crossing Jordan and Bones

Most notably he appeared again and again on the original CSI as the “questionable documents tech” Ronnie Litre.
9. His Career Began in Chicago
There he spent two years doing improv, theater and television commercials while studying with IO Chicago and Second City.
10. He Held Movie Roles in Cameron Crowe’s Almost Famous and IFC’S cult classic Girls Will Be Girls

In Almost Famous he was Sheldon, the hotel desk clerk. Girls Will Be Girls was a selection in the Sundance Film Festival.

";
            }


            else if (teamCounter == 24)
            {
                showText.Text = @"- She says in some ways she can relate to her character, who goes to college in the latest season. “She’s super psyched about it, and then she realises she’s alone and misses her family. I can relate because I moved to California on my own. But I don’t relate to Haley on a lot of other levels!”
- Hey, shortie! Sarah is 1,57 m tall – five centimetres shorter than co-star Ariel Winter (15), who plays her younger sis, Alex.
- Sarah underwent a kidney transplant last year after suffering from kidney dysplasia – malformation of the kidney during fetal development. Her dad, Edward, donated his kidney.
- Show business runs in the family! Sarah’s dad and younger brother, Ian, are both actors and her mom, Melissa Canaday, is an acting coach.
- She calls Ty Burrell (her dad on Modern Family) “my TV dad”. “He’s an amazing, talented person. He’s just as funny in real life as he is on Modern Family.”
- She’d rather watch sport than go shopping. “Shopping stresses me out. I’m drawn to expensive things, but I don’t want to pay $200 [R1 800] for a shirt. I don’t like to spend money.”
- Sex symbol? No thanks, she’d rather be a role model. “By putting yourself out there as a sex symbol, you’re taking a step backward for women.”

";
            }
        }


    }
}