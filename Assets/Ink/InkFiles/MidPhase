==MidPhaseEvent1==
*[Answer Call.]

- Okay, let’s begin. Not sure if you’ve done this before, because I haven't either. I do know the first step however. #Harper
    *[Sounds good Harper.]
    *[Lead on.]
    *[Hurry up, I'm not getting in trouble for this.]
        Hey, I see something stuck up your ass, might want to get it out.#Harper
        ~h_trust = h_trust - 1
    *[...]
        Hey, I’m currently trying to save our skin, not sure if you noticed. #Harper
        ~h_trust = h_trust - 1

- First thing is your station’s Audio Frequency Routing Number, this will let me target and encrypt anything coming from your station. #Harper
    *[Makes sense, let me grab it.]
    *[I can do that, one minute.]
    *[Aren't I in charge here?]
        ~h_trust = h_trust - 1
    *[...]
//Player must open a file, then play mini-game, then get the AFRN.
-->DONE    

- Got the AFRN yet? #Harper
    *[9303H3]
        Try again. #Harper
    *[2823Z2]
        Wrong, again. #Harper
    *[6033G2]
        Nice, were good to go. #Harper
    *[...] 
        H-hello? #Harper
-->DONE 

- Okay, first part is done. But I'll be straight up with you, I’m not sure what to do next. You’re the responder, find the answer. #Harper
    *[Um, okay. Let me look.]
    *[On it.]
    *[Hmph, you sure are helpful.]
        ~h_trust = h_trust - 1
    *[...]
//Player needs to open a flashing folder, 3 ads will appear. Find the Encryption Defense Folder, go through 4 steps.
-->DONE

- Found the next step? #Harper
    *[Hey Harper, to keep going I need your own AFRN and Audio Manager ID.]
    *[Looks good on my end, I’ll need your AFRN and Audio Manager ID to continue.]
    *[Listen up, I need your AFRN and Audio Manager ID to do this.]
        Who do you think you're speaking to!? #Harper
        ~h_trust = h_trust - 1
    *[...]
        Are you listening? #Harper
        ~h_trust = h_trust - 1

- Right. I know our AFRN is 5849, but I don’t know the Audio Manager ID. Call Aaron, he should’ve calmed down by now. #Harper
    *[Okay, I'll call him, see you soon.]
        ~h_trust = h_trust + 1
    *[Sounds good, see you in a bit.]
        ~h_trust = h_trust + 1
    *[Good, I’m getting tired of you too.]
        Trust me, you have no idea. #Harper
        ~h_trust = h_trust - 1
    *[...]
-->DONE

//Player has to call Aaron.
*[Call Aaron]
- Um….Hello? Sorry, I forgot how to use this thing. How can I help you? #Aaron
    *[Aaron, are you okay?]
        ~a_trust = a_trust + 1
    *[How is the captain?]  
        ~a_trust = a_trust + 1
    *[Tell me what’s been going on?]
        ~a_trust = a_trust + 1
    *[...]
        H-hello? Are you there? #Aaron

- The Captain…..he’s gone. A loose crate crushed his chest when the shuttle first shook. It’s……………..all my fault……….I didn’t double check our cargo. I’m so sorry…. #Aaron
    *[Aaron listen to me, it's okay, we’ll fix this.]
        ~a_trust = a_trust + 1
    *[It’s not your fault.]
        ~a_trust = a_trust + 1
    *[He was old, it was bound to happen.]
        Please. Please don't say that... #Aaron
        ~a_trust = a_trust - 2
    *[...]

- Truth is…...I didn’t know how to secure the cargo like he asked. I didn’t want to embarass myself, so I lied……. Please let me help you, I have to make amends, what do you need me to do. #Aaron
    *[Listen to me, we’ll get through this. I need the Audio Manager ID to fix this.]
        Yes, I can do this. We can do this. #Aaron
        ~a_trust = a_trust + 1
    *[Aaron, it wasn’t your fault, let me have the Audio Manager ID so we can fix this.]
        O-okay, let me help you. #Aaron
        ~a_trust = a_trust + 1
    *[Kid, just give me the Audio Manager ID.]
        O-okay.. #Aaron
        ~a_trust = a_trust - 1
    *[...]
        I don’t mean to be needy, but please respond to me…. #Aaron
        ~a_trust = a_trust - 1
    
- Okay……………...one minute, I’m going to grab my booklet, it's got all my notes in it……………………………………..got it! One second please, I’m finding the page right now………………..oh! It’s 84T3-FCAD.
    *[Beautiful, thank you Aaron.]
        ~a_trust = a_trust + 1
    *[Got it, thanks.]
    *[About time.]
        ~a_trust = a_trust - 1
    *[...]
-->DONE

//Now that you have both items, look at the list again, complete step 3. Find a folder named Encryption Levels in the same External Encryption Defense Folder. Use the AmID to cross reference between a long list of encryption status’. Find the right one, it reads: 84T3-FCAD (Argon Albatross) = Encryption Level ‘Axion’. 
//Now take that encryption level and push it to their ship  (this would be the exact same button push mechanic for uploading files from coworker’s computers to our computer, just a simple button press).
//A tutorial will open the option of solving a task with any number of NPCs. This is shown by one final pop-up window. It will say: Call any member of the Red Liner to indicate the encryption’s success.

==MidPhaseEvent2==
- Hey! How’d it go? Please tell me it worked. #Aaron
    *[Worked perfectly, your help was vital.]
        Thank you….you dont know how much that means. #Aaron
        ~a_trust = a_trust + 1
    *[Yeah it worked, just sent it a few seconds ago.]
        Awesome, thank you! #Aaron
    *[Awesome, thank you!]
        It’s okay, for now. #Aaron
    *[...]
        Hello? A-are you there? #Aaron
        ~a_trust = a_trust -1
- Tell me, did the encryption work? #Harper
    *[Worked perfectly, Aaron was vital.]
        Good, he’s learning. #Harper
        ~h_trust = h_trust + 1
    *[Yeah it worked, just sent it a few seconds ago.]
        Good. #Harper
    *[It worked, how’s the shuttle? ]
        Fine. For now. #Harper
    *[...]
        I need you to stay sharp. #Harper
        ~h_trust = h_trust - 1
- Um, h-hey! I really hope it worked, please tell me good news. #Sunny
    *[Worked perfectly, Aaron was vital.]
        Oh! That’s excellent...I-I’m so proud of him! #Sunny
        ~s_trust = s_trust + 1
    *[Yeah it worked, just sent it a few seconds ago.]
        Oh, okay...um, thank y-you! #Sunny
    *[It worked, no thanks to you.]
        ....I-I’m sorry. #Sunny
        ~s_trust = s_trust - 1
    *[...]
        C-can you hear me!? #Sunny
    
- While you were gone, I remembered something! After anything like this we need to run a diagnostic scan. The problem is...I haven't been able to fix the servos in the Bridge to do so. #Aaron
    *[No problem, we can do it together.]
        ~a_trust = a_trust + 1
    *[Let me do it, I’ll just need your help.]
    *[Typical, I got it.]
        ~a_trust = a_trust - 1
    *[...]
- We need to run a scan. Shuttle has taken some damage both internal and external, no telling what’s going to happen to it. #Harper
    *[No problem, we can do it together.]
        ~h_trust = h_trust + 1
    *[Let me do it, I’ll just need your help.]
    *[Typical, I got it.]
        ~h_trust = h_trust - 1
    *[...]
- W-well um….we should really r-run a scan! You never know until you run a s-can afterall! Please can we run it? #Sunny 
    *[No problem, we can do it together.]
        ~s_trust = s_trust + 1
    *[Let me do it, I’ll just need your help.]
    *[Typical, I got it.]
        ~s_trust = s_trust - 1
    *[...]
-->DONE

//Go to your Procedures folder and find the External Scans folder. Open it, a pop-up window will appear just like when you typed in ‘Axion’. It requires their ship’s External Scan Routing Number (ESRN). Navigate back into the Routing folder, find the ESRN. Enter it in the pop-up window.

- Did you start the scan? #Aaron
    *[Alright, the scan is underway; you’ll have to retrieve the results from your end.]
        Okay! #Aaron
    *[Scan is started, though the results will be sent to your end when it's done.]
        Alright! #Aaron
    *[Started the scan, wait for the results, they’ll come to you.]
        Sure. #Aaron
    *[...]
        D-did you send it? #Aaron
        ~a_trust = a_trust - 1
- How's the scan going? #Harper
    *[Alright, the scan is underway; you’ll have to retrieve the results from your end.]
        Roger. #Harper
    *[Scan is started, though the results will be sent to your end when it's done.]
        Good. #Harper
    *[Started the scan, wait for the results, they’ll come to you.]
        Okay. #Harper
    *[...]
        Is the scan confirmed? #Harper
        ~h_trust = h_trust - 1
- D-did you start the scan? #Sunny    
    *[Alright, the scan is underway; you’ll have to retrieve the results from your end.]
        O-okay! #Sunny
    *[Scan is started, though the results will be sent to your end when it's done.]
        Sounds g-good! #Sunny
    *[Started the scan, wait for the results, they’ll come to you.]
        I u-understand. #Sunny
    *[...]
        H-hello? Did you send the s-scan? #Sunny
        ~s_trust = s_trust - 1
//As the scan is loading, the call will drop because of a power surge, a total blackout will occur in your command room. *female voice sounds over YOUR intercom (Power failure. Power failure. Power failure) Go to the breaker box to turn it on. 
-->DONE
    
//Coming back, you must call the last person you spoke to.
- Hey! Something is happening, the ship just jerked again! This time I heard a loud noise...do you want me to go, or should someone else while I stay at the bridge to handle the scan results? #Aaron
    *[No, stay at the bridge; I'll call someone else.]
        Right! I’ll do whatever you need me to. #Aaron
        ~a_trust = a_trust + 1
    *[Yes, go to the noise, tell Harper to go wait at the bridge for the scan.]
        O-okay! I’ll pass it on! #Aaron
        ~a_trust = a_trust + 1
    *[Yes, go investigate the noise, tell Sunny to watch the bridge for the scan.]
        R-right! I’ll tell her now! #Aaron
    *[...]
        W-what do you want me to do!? #Aaron
        ~a_trust = a_trust - 1
- Something’s wrong. I can feel it. We jerked again, there was another crash. Either I go look or someone else does, make the call. #Harper
    *[No, stay at the bridge; I'll call someone else.]
        Roger. #Harper
        ~h_trust = h_trust + 1
    *[Yes, go to the noise, tell Harper to go wait at the bridge for the scan.]
        Understood, I’ll tell him now. #Harper
        ~h_trust = h_trust + 1
    *[Yes, go investigate the noise, tell Sunny to watch the bridge for the scan.]
        Understood, I’ll tell him now. #Harper
    *[...]
        Look. We have no time for this bullshit, respond to me. #Harper
        ~h_trust = h_trust - 1
- We’ve got a real p-problem here! The s-ship jerked again! There was another loud b-boom! Please tell me what to do, should I s-stay at the bridge or g-go look!? #Sunny
    *[No, stay at the bridge; I'll call someone else.]
        O-okay! #Sunny
        ~s_trust = s_trust + 1
    *[Yes, go to the noise, tell Harper to go wait at the bridge for the scan.]
        Um okay! I’ll go right now and tell Harper w-when I’m there! #Sunny
        ~s_trust = s_trust + 1
    *[Yes, go investigate the noise, tell Sunny to watch the bridge for the scan.]
        A-alright! I’ll tell him! #Sunny
    *[...]
        P-please respond! #Sunny
        ~s_trust = s_trust - 1
-->DONE
    
===MidPhaseEvent3===
//This dialog serves as sending whoever you choose to the impact noise. Whoever takes over the scan room, they are locked out of future use for the rest of the Mid Phase.
- O-okay. I can do that. I’m heading there right now…………………….………looks to be more engine trouble………………..…..let me………...…..oh no! The engine power is failing. It’s falling quickly, they’re gonna rupture if we cant pull them back! #Aaron
    *[We’ll figure it out, I’m sure.]
        ~a_trust = a_trust + 1
    *[Let’s get started then.]
    *[Isn’t this your job?]
        You bet it is. #Aaron
        ~a_trust = a_trust - 1
    *[...]
- Good idea. I’ll look. Sounds like the engine room, not much else can make that noise on this side of the Liner…………………………...………………...Well, fuck. Aaron would know more, but it looks like we have engine failure. The power output is showing red. #Harper
    *[We’ll figure it out, I’m sure.]
        ~h_trust = h_trust + 1
    *[Let’s get started then.]
    *[Maybe I should’ve sent Aaron…]
        Shut up. #Harper
        ~h_trust = h_trust - 1
    *[...]
- Oh! W-well I can go look! Just please stay on the line. It l-looks to me like it's coming from the engine room. I d-don't know as much as Aaron but the power is l-low. We n-need to fix this quickly!! #Sunny
    *[We’ll figure it out, I’m sure.]
        ~s_trust = s_trust + 1
    *[Let’s get started then.]
    *[Maybe I should’ve sent Aaron…]
        Y-yeah…….I’m really s-sorry. #Sunny
        ~s_trust = s_trust - 1
    *[...]
    
- It looks to me like the spacial carburetors are failing to emit their burnoff, its slowing the engines down. I…..I’m not gonna lie, this is gonna be dangerous, but I can fix it. I need you to tell me what's going on inside the engine. #Aaron
    *[Be careful Aaron, I’ll find the engine info.]
        ~a_trust = a_trust + 1
    *[Okay, I can do that.]
    *[If you say so.]
    *[...]
- I know it's a power failure, look at your information. Just tell me what to do. I’ll do it, just don't get me killed. #Harper
    *[Be careful Harper, I’ll find the engine info.]
        ~h_trust = h_trust + 1
    *[Okay, I can do that.]
    *[If you say so.]
    *[...]
- O-okay….um….well it looks bad. It’s giving off low power and it's really hot in here. Just t-tell me what to do please!! #Sunny
    *[Be careful Sunny, I’ll find the engine info.]
        ~s_trust = s_trust + 1
    *[Okay, I can do that.]
    *[If you say so.]
    *[...]
-->DONE  

//The player will have to go back into the Engine Diagnostic file from the previous phase event. They will then have to take this graph to the Procedures folder. Then locate the Hardware Failure folder. Now find the Engines folder. When they try to open the Albatross folder they’ll have to beat the hacking mini-game to open it. Finally the instructions will be laid out.
//Now go through the steps one at a time: (This is you talking to whoever you are speaking to)
- What do you need from me? #Aaron
    *[Tell me what the engine output is reading.]
        Right. #Aaron
    *[I need the engine output first.]
        Okay. #Aaron
    *[Give me the engine output.]
        Got it. #Aaron
    *[...]
        My book says you'll need my output... #Aaron
        ~a_trust = a_trust - 1
- What do you need? #Harper
    *[Tell me what the engine output is reading.]
        On it. #Harper
    *[I need the engine output first.]
        Understood. #Harper
    *[Give me the engine output.]
        Roger. #Harper
    *[...]
        Let me do your job, you need my engine output. #Harper
        ~h_trust = h_trust - 1
- W-what do you need from me? #Sunny
    *[Tell me what the engine output is reading.]
        O-okay! #Sunny
    *[I need the engine output first.]
        O-okay! #Sunny
    *[Give me the engine output.]   
        O-okay. #Sunny
    *[...]
        D-do you need the engine output? #Sunny
        ~s_trust = s_trust - 1
        
- Right, I-I already looked, it's reading 241RW, that's low…..too low. It should be near 500RWs……………..I’ll start shutting down the engine. #Aaron
    *[Perfect, thank you. Let me know when it’s done.] 
        Will do! #Aaron
        ~a_trust = a_trust + 1
    *[Thank you Aaron, this is great.]
        Thank you! #Aaron
        ~a_trust = a_trust + 1
    *[Hurry it up kid, another jerk may be happening.]
        Yeah...you’re right. #Aaron
        ~a_trust = a_trust - 1
    *[...]
        Hello? A-are you there? #Aaron
- 241RW. It’s reading 241RW, what next? #Harper
    *[Thank you, next perform engine shutdown.]
        Understood. #Harper
        ~h_trust = h_trust + 1
    *[Got it, shut the engine down.]
        On it. #Harper
    *[Shut the engine down.]
        Okay. #Harper
    *[...]
        What next...? #Harper
        ~h_trust = h_trust - 1
- Oh! O-okay! Let me see………...its….its...241RW! Yes! 241RW! W-what do you want me to do next? #Sunny
    *[Thank you, next perform engine shutdown.]
        O-okay. #Sunny
        ~s_trust = s_trust + 1
    *[Got it, shut the engine down.]
        Um o-okay. #Sunny
    *[Shut the engine down.]
        S-sure… #Sunny
    *[...]
        Hellooo? #Sunny
        ~s_trust = s_trust - 1
   
- It should be shutting down right now…..yeah! I’m gonna give it a second and open the hood. #Aaron
    *[Sounds good, tell me what you find.]
    *[Okay, tell me what’s in there.]
    *[What’s in there?]
    *[...]
- Roger. Tell me how to do that. #Harper
    *[Find the electrical input and atomic bypass gauges, turn them to 0 slowly, do it together.]
    *[Look for the electrical input and atomic bypass gauges. Turn them off slowly, it has to be together.]
    *[Listen. Find two gauges, electrical input and atomic bypass. Turn them to 0 together.]
    *[...]
        Give me directions damnit! #Harper
- Oh, okay! W-well, how do I do that? #Sunny
    *[Find the electrical input and atomic bypass gauges, turn them to 0 slowly, do it together.]
    *[Look for the electrical input and atomic bypass gauges. Turn them off slowly, it has to be together.]
    *[Listen. Find two gauges, electrical input and atomic bypass. Turn them to 0 together.]
    *[...]
        Um…I n-need your help! #Sunny
    
- Um….this isn’t good. The wiring is intact but the electrical components must’ve lost their connection during the jerking, it then sat against the overheating engine and is fucked.……. Should I try and rewire this? #Aaron
    *[Please do, why’re you asking?]
        Wanted to update you is all. #Aaron
        ~a_trust = a_trust + 1
    *[Yes, of course, why’re you asking?]
        J-just wanted to ask. #Aaron
    *[Obviously. What’s wrong?]
        ~a_trust = a_trust - 1
    *[...]
- Okay………...Simple. It’s off. Now what? #Harper
    *[Okay, next you need to open the engine and find the internal wiring.]
        ~h_trust = h_trust + 1
    *[Open the hood, look for the wiring near the core.]
    *[Easy. Find the wiring.]
    *[...]
        Look. I need your help...so give it to me. #Harper
        ~h_trust = h_trust - 1
- O-okay………..here I go………….please...please….please………….I-I think it worked? Y-yeah! Okay, now what? #Sunny
    *[Okay, next you need to open the engine and find the internal wiring.]
        ~s_trust = s_trust + 1
    *[Open the hood, look for the wiring near the core.]
    *[Easy. Find the wiring.]
    *[...]
        T-t-tell me what t-to do… #Sunny
        ~s_trust = s_trust - 1
    
- Well, it….it could be dangerous. There’s no doubt the engine is unstable. I’ll do whatever, just let me know. #Aaron
    *[Do it, just be careful.]
        ~a_trust = a_trust + 1
    *[Go ahead, take your time.]
        ~a_trust = a_trust + 1
    *[Don’t do it.]
        I-I think I have too.. #Aaron
    *[...]
        ~a_trust = a_trust - 1
- Wires are fine, electronics look fucked. Want me to rewire the engine….I know 	to do that much at least, spend a lot of time in the bridge. #Harper
    *[Do it, just be careful.]
        ~h_trust = h_trust + 1
    *[Go ahead, take your time.]
        ~h_trust = h_trust + 1
    *[Don’t do it.]
        Are you sure? I think I have too. #Harper
    *[...]
        ~h_trust = h_trust - 1
- W-well! It...um….oh…...it looks like the wires are o-okay…….The circuit boards look pretty f-fried though! S-should I rewire them? It’s l-like s-stitches! #Sunny
    *[Do it, just be careful.]
        ~s_trust = s_trust + 1
    *[Go ahead, take your time.]
        ~s_trust = s_trust + 1
    *[Don’t do it.]
        Um….w-well…..I think I have too… #Sunny
    *[...]
        ~s_trust = s_trust - 1
-->DONE

//If anyone tries to fix the wiring but Aaron it will cause them damage, they won’t die. This establishes the idea of certain NPCs having certain advantages over others in specific jobs, and the idea of NPC damage and eventual death.
- Let me see……..give me a minute………………………………………….got one………………………..make that two……………………..thr-wait……..three. O-okay, I think that’ll work. #Aaron
    *[Great job Aaron.]
        ~a_trust = a_trust + 1
    *[Good job man.]
        ~a_trust = a_trust + 1
    *[Nice.]
        ~a_trust = a_trust + 1
    *[...]
- Okay. Give me a moment……………………………………….I’ve got one. The next one looks stuck……………………………………………….fuck, I can’t get it. One second……………………………………………..FUCK! The fucking wire is still live! Burned my fucking arm! #Harper
    *[Oh my god, Harper get to Sunny right now!]
        ~h_trust = h_trust + 1
    *[Are you okay!?! Go get Sunny!]
        ~h_trust = h_trust + 1
    *[Roy died, suck it up. Go see Sunny.]
        ~h_trust = h_trust - 4
    *[...]
- Um okay…….let me see……………………………….this first wire looks okay……………………...s-second one is a bit s-stuck. Um, let me l-look at this third one………………………...OWW! AHH! It burned m-my arm!! #Sunny
    *[Oh my god, Sunny, get to your infirmary right now!]
        ~s_trust = s_trust + 2
    *[Are you okay!?! Go get to your infirmary.]
        ~s_trust = s_trust + 2
    *[Roy died, suck it up. Get your tools.]
        ~s_trust = s_trust - 6
    *[...]
-->DONE
    
===MidPhaseEvent4===
//The third NPC will call (the one you haven't used for Phase Event 2 or 3).
- H-hey. I just wanted to let you know we’ve got an emergency coming from the Mess Hall, I’ll head there right away. #Aaron
    *[Okay, let me know what’s going on.]
        I will. #Aaron
    *[Sounds good, update me.]
        I will. #Aaron
    *[Tell me what’s going on.]
        I will. #Aaron
    *[...]
- This shit never ends. Something is going on in the mess hall, on my way. #Harper
    *[Okay, let me know what’s going on.]
        Roger. #Harper
    *[Sounds good, update me.]
        Roger. #Harper
    *[Tell me what’s going on.]
        Roger. #Harper
    *[...]
- Why c-cant this all just be over! There’s s-something going on in the mess hall, I’m gonna go there n-now…… #Sunny
    *[Okay, let me know what’s going on.]
        O-okay! #Sunny
    *[Sounds good, update me.]
        O-okay! #Sunny
    *[Tell me what’s going on.]
        O-okay. #Sunny
    *[...]
-->DONE

//There will be a fire going on in the Mess Hall, it was started due to the attackers tampering with power frequencies in the burners/whatever is used to cook food.
- Oh god…..um….t-there’s a fire! #Aaron
    *[Oh my god! Let's put it out!]
        A-alright! #Aaron
    *[Of course there is...let's put it out.]
        A-alright! #Aaron
    *[Which one of you broke an ancient mirror?]
        What're you talking about!?! #Aaron
        ~a_trust = a_trust - 1
    *[...]
- There’s a fucking fire in here, how in god’s name did this even start? #Harper
    *[Oh my god! Let's put it out!]
        Agreed. #Harper
    *[Of course there is...let's put it out.]
        Agreed. #Harper
    *[Which one of you broke an ancient mirror?]
        Huh, funny. #Harper
        ~h_trust = h_trust + 2
    *[...]
- OH M-MY GOD! THERE’S A F-FIRE!!!!!! #Sunny
    *[Oh my god! Let's put it out!] 
        Oh g-god! #Sunny
    *[Of course there is...let's put it out.]
        Oh g-god! #Sunny
    *[Which one of you broke an ancient mirror?]    
        W-what? I d-didn't break anything! #Sunny
        ~s_trust = s_trust - 2
    *[...]
    
- I’m at the fire failsafe…..one second…..I know the code……………..please work…………………………….....it’s not working! You need to override this system, it's locking me out! #Aaron
    *[Give me a minute, I'll take care of it.]
        ~a_trust = a_trust + 1
    *[Sounds simple enough.]
    *[On it.]
    *[...]
- Okay. I’m at the fire failsafe………...fuck………..shit…..damnit……..it’s not working! Listen, override this junk and let me in! #Harper
    *[Give me a minute, I'll take care of it.]
        ~h_trust = h_trust + 1
    *[Sounds simple enough.]
    *[On it.]
    *[...]
- I c-can’t do this! This is all t-too much! Just override the fire failsafe s-system!!! #Sunny
    *[Give me a minute, I'll take care of it.]
        ~s_trust = s_trust + 1
    *[Sounds simple enough.]
    *[On it.]
    *[...]
-->DONE 

//Play the Decrypting mini-game to override the fire failsafe. If you fail twice the person inside the room will die.
//With Death: (This dialog is ignored if no one dies) A surviving member of the crew will come in and see the dead body.
- Oh fuck...they’re not moving! W-what happened? #Aaron
    *[I took too long….I’m sorry Aaron…]
        ~a_trust = a_trust - 3
    *[I couldn’t break through in time…]
        ~a_trust = a_trust - 3
    *[It’s my fault. I took too long.]
        ~a_trust = a_trust - 3
    *[...]
        ~a_trust = a_trust - 3
- Fuck...they’re not moving. What happened? #Harper
    *[I took too long….I’m sorry Harper…] 
        ~h_trust = h_trust - 3
    *[I couldn’t break through in time…]
        ~h_trust = h_trust - 3
    *[It’s my fault. I took too long.]
        ~h_trust = h_trust - 3
    *[...]
        ~h_trust = h_trust - 3
- Oh f-fuck...they’re not moving! W-what happened? #Sunny
    *[I took too long….I’m sorry Sunny…]
        ~s_trust = s_trust - 3
    *[I couldn’t break through in time…]
        ~s_trust = s_trust - 3
    *[It’s my fault. I took too long.]
        ~s_trust = s_trust - 3
    *[...]
        ~s_trust = s_trust - 3

//Without Death: (Here no NPC died to begin with so you skip the above bulletpoint.)
- Oh my god….it's working! #Aaron
    *[Of course.]
        ~a_trust = a_trust + 1
    *[Anytime.]
        ~a_trust = a_trust + 1
    *[Thanks.]
        ~a_trust = a_trust + 1
    *[...]
        ~a_trust = a_trust + 1
- You’ve done it. Good work. #Harper
    *[Of course.]
        ~h_trust = h_trust + 1
    *[Anytime.]
        ~h_trust = h_trust + 1
    *[Thanks.]
        ~h_trust = h_trust + 1
    *[...]
        ~h_trust = h_trust + 1
- O-oh god you did it! You’re amazing, t-thank you! #Sunny
    *[Of course.]
        ~s_trust = s_trust + 1
    *[Anytime.]
        ~s_trust = s_trust + 1
    *[Thanks.]
        ~s_trust = s_trust + 1
    *[...]
        ~s_trust = s_trust + 1
-->DONE

//After you beat it your entire screen will be covered in pop-ads (like 50 of them). As you close 1/3rd of them, your power will shut off. 

===MidPhaseEvent5===
//Now the scan results will come in whenever you turn the power back on. Before the NPC you sent to stay by the scan results calls you back, you will receive a dead call. This dead call will introduce the player to the mechanic. There will only be a clear static noise that comes overhead. After 5 seconds the call will end. This dead call won't show the ‘caller ID’ or image like the other crew members, making it stand out. Once the player answers this call the timer will lose 1 minute, making a static warning noise as the timer beeps down.
- Hey! The fire is dying down, the failsafe activated. Um, another thing, the results just came back from your end...and it……..it doesn’t look good. The ship….it’s falling apart. It says we’ve only got a few minutes before it really starts to begin breaking down… #Aaron
    *[Okay, we need to get everyone off the ship.]
        ~a_trust = a_trust + 1
    *[We can do this, we need everyone to leave the ship.]
    *[Get off the ship.]
    *[...]
- Two things. I’ll start with the good. The fire is nearly out, the failsafe is doing its job. Update on the scan results, they’re fucked. This piece of junk is falling apart, it’s got a few minutes before the real tearing apart happens. #Harper
    *[Okay, we need to get everyone off the ship.]
        ~h_trust = h_trust + 1
    *[We can do this, we need everyone to leave the ship.]
    *[Get off the ship.]
    *[...]
- S-so, the fire is almost out! You did a f-fantastic job on the failsafe, it’s killing the f-fire…...but….um…...the scan came back…...and…...w-well…….this shuttle is falling apart…...W-we only have a few minutes before it really starts to tear apart…. #Sunny
    *[Okay, we need to get everyone off the ship.]
        ~s_trust = s_trust + 1
    *[We can do this, we need everyone to leave the ship.]
    *[Get off the ship.]
    *[...]
-->DONE
