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
        ->PhaseEvent2
    -else:
        Do nothing...
}

//Game Intro

//Call rings
->PhaseEvent2

==PhaseEvent2==
Answer Call #Roy
    *[Thank you for calling TPS, how may I help?]
    
    *[Captain Estrada? This is TPS.]
        "Perfect, just who I needed to talk to." #Roy
    *[TPS here. Who am I speaking with?]
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
        Hello? Do you think you could help? #Roy
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
    *[Simple enough. Please tell me your engine's ID code.]
    *[Hm, okay, Aaron. First, tell me the engine's ID code.]
    *[What's the ID code of your engine?]
    *[Slow down. What's your ID code?]
    
-Oh, right! Give me a minute here... #Aaron
    Sorry about this... almost there... #Aaron
    Okay, I got it! #Aaron
    It's 93015-H3. #Aaron
    Oh, wait... No, drop the last 3. #Aaron
    It's 93015-H.
    
->DONE