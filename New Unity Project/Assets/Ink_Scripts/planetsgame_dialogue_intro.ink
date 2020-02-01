
//p1 = tall figure, older, wiser, magnanimous
//p2 = player character


Oh. It appears you have done it now. # p1
->intro_choice_1

=== intro_choice_1 ===
It so appears. I guess I shouldn’t... #p2
* [...have played with gravity like that.] #p2
-> intro_pt1
* [...tested the limits of light speed.] #p2
-> intro_pt1
* [...have tried to merge two timelines.] #p2
-> intro_pt1

=== intro_pt1 ===

What change does it make how you, how we ended up here, if we end here the same. # p1

You have the chance to take things in your own hands, or the responsibility. # p1

Nobody but you can, since only you see it with your perspective. # p1

Such is the state of things. # p1
->intro_choice_2

=== intro_choice_2 ===
* [The consequences are too big to fathom. I don't think I can handle it.] # p2
->intro_pt2

=== intro_pt2 ===
Alas... #p1
->intro_choice_3


=== intro_choice_3 ===
* [Has time really led us here?] #p2
-> intro_pt3
* [Isn’t there a way out?] #p2
-> intro_pt3
* [I regret my actions. I regret my inaction as well.] #p2
-> intro_pt3


=== intro_pt3 ===
Alas... #p1

//Console glows, P1 goes to console
#movetoconsole
->intro_choice_4


=== intro_choice_4 ===
    * [I wish there was a way for actions to be undone.] #p2
->intro_pt4

=== intro_pt4 ===
Alas… here, time only flows one way. As long as we witness it. #p1
->intro_choice_5

=== intro_choice_5 ===
* [What’s the point of order, if all can fall apart? Are we ever safe?] #p2
->intro_pt5


=== intro_pt5 ===
We are meant to oversee the equilibrium. You know. #p1
->intro_choice_6

=== intro_choice_6 ===
* [But why?] #p2
->intro_pt6

=== intro_pt6 ===
... #p1
->intro_choice_7

=== intro_choice_7 ===
* [This galaxy looks the way it used to, but will it ever feel the same?] #p2
->intro_pt7

===intro_pt7
Sometimes, things stay the same, yet your perspective change them in ways unforeseen. #p1
At the same time, things always change. #p1
-> puzzle1complete


=== puzzle1complete ===
I don’t think I understand. #p2

Whether or not you understand something colours your perspective. #p1
Yet the rainbow has an infinite amount of colours. #p1
And all the colours are true. #p1

... #p1

Shall we continue? #p1

* [Do I have a choice?] #p2
-> intro_pt7b

=== intro_pt7b ===

What do you like about the notion of choice? #p1

* [I like to feel in control of my destiny] #p1 
-> intro_pt8
* [I like to feel like I have options] -> #p1 
-> intro_pt8
* [I don’t want to feel stuck in a tragedy] -> #p1 
-> intro_pt8

=== intro_pt8 ===

Since you will only ever experience one timeline, what difference does it make? #p2

... #p1

* [...] #p2
-> intro_pt9

=== intro_pt9 ===

Let's continue

//The tall character disappears. The player follows them.

You almost ended the world, you know? #p1

* [I might have.] #p2
-> s1_1
* [The important part is that I fix it.] #p2
-> s1_1
* [...I should have] #p2
-> s1_1

=== s1_1 ===

As long as we are, the world will be. #p1

* [Why are we putting it together again if things still exist.] #p2
-> s1_2

=== s1_2 ===

Change brings forth consequences. Manifold destinies, altered. #p1

* [Maybe it’s for the best.] #p2
-> s1_3
* [To think of all the beings I affected…] #p2
-> s1_3

=== s1_3 ===

New isn’t always better. #p1
And at least now you’ll have an intimate knowledge of the order. #p1
You will have created the universe anew. #p1

* [This feels right.] #p2
-> s1_4
* [This feels wrong.] #p2
-> s1_4
* [I don’t know what to feel.] #p2
-> s1_4

=== s1_4 ===

Sometimes it is best not to think too much about what you feel. #p1

* [Order is tiresome.] #p2
-> s1_5
* [Chaos is tiresome.] #p2
-> s1_5
* [Responsibilities are tiresome.] #p2
-> s1_5

=== s1_5 ===

It’s true. #p1

* [Isn’t everything true?] #p2
-> s1_6

=== s1_6 ===

You are starting to get it. #p1

* [...] #p2
-> s1_7

=== s1_7 ===

* [Waves of realisation slowly wash upon me, crashing upon my thoughts.] #p2
-> s1_8

=== s1_8 ===

* [It’s hard sometimes not to be swept away.] #p2
-> s1_10

=== s1_10 ===

It is always hard. #p1
Any choice for something means a choice against countless other things. #p1

* [I feel myself slipping, swallowed.] #p2
-> s1_11

=== s1_11 ===

* [It feels like the emptiness is all encompassing.] #p2
-> s1_12

=== s1_12 ===
Do you have regrets? #p1

* [I don’t think I regret my actions, I just regret the consequences] #p2
-> s1_13
* [I did what I thought was right, so I must own up to it.] #p2
-> s1_13
* [Yes. I shoulder the shame of my actions.] #p2
-> s1_13

=== s1_13 ===

Regrets don’t exist in a vacuum. #p1
At least you must have learned something. #p1

* [I am not sure I did. I don’t know that I am any wiser.] #p2
-> s1_14
* [Can you learn things without regrets, without things not going according to expectations?] #p2
-> s1_14
* [What if my interpretation differs from others’? Isn’t knowledge shared?] #p2
-> s1_14

=== s1_14 ===

We are here to bear witness. Yet knowledge is based in judgement. #p1
Order is based in judgement. #p1

* [...] #p2
-> s1_15

=== s1_15 ===





-> END