INCLUDE MidPhase
INCLUDE GoPhase
INCLUDE FakeCalls


//NOTES
//-- Tag Guide --//
    //#R = Roy
    //#A = Aaron
    //#H = Harper
    //#S = Sunny
//-- End Guide --//

//VARIABLES AND FUNCTIONS
VAR r_trust = 10 //Roy's trust in you
VAR a_trust = 12 //Aaron's trust
VAR h_trust = 8 //Harper's trust
VAR s_trust = 10 //Sunny's trust

//DEBUG MODE
TODO: DEBUG MODE
VAR DEBUG = true
{DEBUG:
        ->PhaseEvent3
    -else:
        Do nothing...
}

//Game Intro

==PhaseEvent2==
Answer Call #Roy
    *[Thank you for calling TPS, how can I help?]
    
    *[Captain Estrada? This is TPS.]
        Perfect, just who I needed to talk to. #Roy
    *[Titan Public Safety. Who am I speaking with?]
        My name is Roy Estrada. I'm the captain of the Redliner. #Roy
            **[It's nice to meet you, Captain Estrada.]
                Please, call me Roy. I'm calling to report an issue. #Roy
            **[Pleased to meet you, Captain.]
                And you. Now if you could help us out. #Roy
            **[Welcome to my sector, Roy.]
            ~r_trust = r_trust + 1
                Thank you, we just crossed into sector 6 not but two hours ago. It seems like Titan's slow this time of year. #Roy
                    ***[Quite. Now, what appears to be the issue?]
                        Ah, right. <> #Roy
                    ***[Titan's slow every time of year.]
                        //Laughter?
                        Well, fortunately, I have something for you to do. #Roy
                    ***[...]
                        I'm not sure if you said anything, but... #Roy
            **[Alright, what do you need?]
            ~r_trust = r_trust - 1
                Hmph. Well, let me get into it. #Roy
            **[...]
    TODO: Might change the timer here, if we manage to add buffer time in Unity
    *[<20>...]
        Hello? Is anyone there? #Roy
        ~r_trust = r_trust - 1
            {TURNS_SINCE(->PhaseEvent2) > 3:
                Maybe it's a wrong number? #Aaron
                I guess I'll try calling back later. #Roy
                TODO: Send back to ringing phone/end call!!
                ->DONE
            } ->PhaseEvent2

-Looks like this old girl has run into some problems. Our primary engine is building up pressure even after our engineer ran through our system diagnostics...  #Roy
    I trust he knows what he's doing, but could you help him out? #Roy
    *[Welcome to, Captain.]
        Excellent, thank you! #Roy
    *[Of course!]
        Excellent, thanks! #Roy
    *[I can do that.]
        Alright, thank you. #Roy
    *[If you need me to.]
        ...One second... #Roy
    *[...]
        Hello? My communication may be spotty, but anyways... #Roy
-I'll pass communications over to Aaron, but I'll be standing nearby if you need any help. #Roy
    //Static/Feedback
    Uh... Hello? Can you hear me? This is Aaron Bedford. #Aaron
    *[Pleased to meet you, Aaron.]
    ~a_trust = a_trust + 1
        You... you as well. Let me tell you what's happening... #Aaron
    *[Hello, Mr. Bedford.]
        Oh, hello! Let me tell you what's happening... #Aaron
    *[How can I help, Aaron?]
    *[What's the problem?]
    *[...]
    ~a_trust = a_trust - 1
    
-Well, um, I ran through the primary engine checklist. #Aaron
    Nothing is seriously wrong, but I know I probably messed something up. The temperature keeps rising and it won't go down. #Aaron
    It says to call you in case of emergency, and well, I didn't want to take anay chances, you know? #Aaron
    *[Okay, Aaron. First, tell me the engine's ID code.]
    *[What's the ID code of your engine?]
    *[Slow down. What's your ID code?]
    *[...]
    
-Oh, right! Give me a minute here... #Aaron
    Sorry about this... almost there... #Aaron
    Okay, I got it! #Aaron
    It's 93015-H3. #Aaron
    Oh, wait... No, drop the last 3. #Aaron
    It's 93015-H.
    *[It's no problem at all!]
    
    *[Let me take a look.]
    
    *[Oh, don't worry. Take your time...]
    ~a_trust = a_trust + 1
        Oh, thank you. Uh, well, I'll wait here...
    *[...]
    
//POP UP TUT. PLAYER SEARCHES ENGINE ROOM LOG. 
-->DONE

=PE2A
    *[From this report, it looks like the emission valves are closed.]
        Okay, let me try this... #Aaron
        Um... nothing is hapening, the temperature is the same. #Aaron
        Maybe, you could look again? #Aaron
        ->PE2A
    *[Hey, Aaron, it looks like the ventilation stopped working.]
    
    *[Hmm, looks like the CO2 levels are clogging the alternator.]
        Okay, let me try this... #Aaron
        Um... nothing is hapening, the temperature is the same. #Aaron
        Maybe, you could look again? #Aaron
        ->PE2A
    *[This it may be the secondary pistons.]
        Okay, let me try this... #Aaron
        Um... nothing is hapening, the temperature is the same. #Aaron
        Maybe, you could look again? #Aaron
        ->PE2A
        
    *[<5000>...]
        ->PE2A
        
-Well, it looks good over here so far. Thank you so much! Have a good night! #Aaron

    End Call.
-->DONE

==PhaseEvent3==
*[Answer Call.]

-Hi, call me Harper. Got another problem for you. #Harper
Annoying-ass feedback is coming over the intercom system. #Harper
Estrada sent Bedford into the Communications Room. We need help, can you do it? #Harper
    *[Of course, Harper.]
    *[That's why I'm here.]
    *[What am I going to do, leave?]
    ~h_trust = h_trust-1
        Try that again, I dare you. #Harper
        I just needed to know you could hear me so <>
    *[...]
    ~h_trust = h_trust-1
        You there? #Harper
        Listen up, <> #Harper
    
-<>I know we're in range. #Harper
Check our map file and tell me which intercom box is broadcasting. #Harper
    *[Alright, let me check.]
    *[...]
        Hey, can you hear me? #Harper
        Are you there? #Harper
        Fuck it. #Harper
        ->DONE
        TODO: Fix the above silent option

//PLAYER FINDS SHIP INFORMATION; THEN FAKE CALL; THEN POWER GOES OUT
-->DONE

=PE3A
*[Answer Call]

-Th-this is Sunny speaking. I mean, uh, Sunny du Vois speaking. Acting ph-physician and medic on the Red Liner. #Sunny
    We seem to have a m-major problem here! #Sunny
    *[Sunny, what's going on?]
    *[What happened?]
    *[Spit it out.]
    ~s_trust = s_trust-1
        Oh! S-sorry! #Sunny
    *[...]
        Please don't go! #Sunny
            *[I'm still here!]
                Oh... oh, good. #Sunny
            *[...]
            ~s_trust = s_trust-1

-Aaron is hurt! He turned the Intercom off, b-but it shocked him. #Sunny
    I patched him up. He's stable but in pain. R-Roy and I are with him in the, uh... #Sunny
    The, uh... #Sunny
    Infirmary! Could you please call medical dispatch?! #Sunny
    *[Right away!]
    *[Of course, Sunny.]
    *[By the time you get a word out?]
    *[...]

//PLAYER HITS MEDICAL DISPATCH BUTTON
-->DONE

=PE3B
//A call to Medical Dispatch
Hello TPS, this is Medical Dispatch. #MD
    Please give me the ships ID signature so we can transpond to their location. #MD
//PLAYER CHECKS SHIP INFO MAP FOR CODE
    -(opts)
        *[ARA3-04931]
            Perfect, I see them. We're on our way! #MD
            Just tell them to sit tight, and we'll contact you once we reach them. Good Day. #MD
        *[AR-05302]
            I don't see anything... #MD
            Give it to me one more time; we're going to need the right code. #MD
            ->opts
        *[A3-2931315]
            I don't see anything... #MD
            Give it to me one more time; we're going to need the right code. #MD
            ->opts
        *[ARAM-01842]
            I don't see anything... #MD
            Give it to me one more time; we're going to need the right code. #MD
            ->opts
        *[...]
            Hello? I can't hear you. Please give me the ship's ID signature. #MD
            ->opts
//COUNTDOWN TIMER STARTS
-->DONE

==PhaseEvent4==
*[Switch to Sunny]
    Oh-oh, you're back! Are they co- *static*  #Sunny
    Error in transmission #fake
//SITE GLITCHES OUT; PLAYER HAS TO CLOSE POP UPS AND TURN LIGHTS ON
-->DONE

=PE4A
*[Answer Call]
    Dispatch better be coming. Captain's gone. #Harper
    Cargo flattened his chest when our ship went sideways. #Harper
    I need y-Damnit Sunny! Get Bedford out of here! #Harper
        *[What's going on?]
        *[Hey! Focus.]
        ~h_trust = h_trust+1
            I am focused! #Harper
        *[Roy's dead?]
            Correct... #Harper
        *[...]
    
    -One of the engines blew in the jolt. It crashed our energy shields. #Harper
    If it happens again without that shield, we're done. Get it up with me, now. #Harper
        **[Harper, we've got this.]
        **[I can do that!]
        **[The screaming makes it hard to concentrate.]
            I couldn't agree more... Poor boy. #Harper
        **[...]
        
    -I made it to the bridge. It looks sketchy in here. #Harper
        Servos ar- #Harper
    Fuck. Okay, listen. I know how to fix this.
        I just need your help rerouting some of the power back to the shields.
        *[I'll follow your lead.]
        Good. You have a shield map, don't you? #Harper
            **[Right, let me check.]
        *[If you say so, let me get the file.]
        *[Works for me. I'll be right back.]
        *[...]
            ~h_trust = h_trust - 1
            Hey! This isn't the time to be slacking! #Harper
            Just... Check whatever files you have and get back to me. #Harper
    
    -
-->DONE