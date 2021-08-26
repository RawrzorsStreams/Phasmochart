Public Class Form1
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        Text = "test"

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label43_Click(sender As Object, e As EventArgs) Handles Label43.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each Label As Control In GroupBox1.Controls
            If (Label.Text = "Spirit Box") Then If Label.BackColor = Color.Transparent Then Label.BackColor = Color.Green Else If Label.BackColor = Color.Green Then Label.BackColor = Color.Transparent


        Next Label

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For Each Label As Control In GroupBox1.Controls
            If (Label.Text = "Fingerprints") Then If Label.BackColor = Color.Transparent Then Label.BackColor = Color.Green Else If Label.BackColor = Color.Green Then Label.BackColor = Color.Transparent

        Next Label
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        For Each Label As Control In GroupBox1.Controls
            If (Label.Text = "Ghost Writing") Then If Label.BackColor = Color.Transparent Then Label.BackColor = Color.Green Else If Label.BackColor = Color.Green Then Label.BackColor = Color.Transparent

        Next Label
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        For Each Label As Control In GroupBox1.Controls
            If (Label.Text = "Freezing Temps") Then If Label.BackColor = Color.Transparent Then Label.BackColor = Color.Green Else If Label.BackColor = Color.Green Then Label.BackColor = Color.Transparent

        Next Label
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        For Each Label As Control In GroupBox1.Controls
            If (Label.Text = "EMF 5") Then If Label.BackColor = Color.Transparent Then Label.BackColor = Color.Green Else If Label.BackColor = Color.Green Then Label.BackColor = Color.Transparent


        Next Label
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        For Each Label As Control In GroupBox1.Controls
            If (Label.Text = "Ghost Orb") Then If Label.BackColor = Color.Transparent Then Label.BackColor = Color.Green Else If Label.BackColor = Color.Green Then Label.BackColor = Color.Transparent


        Next Label
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        For Each Label As Control In GroupBox1.Controls
            If (Label.Text = "D.O.T.S.") Then If Label.BackColor = Color.Transparent Then Label.BackColor = Color.Green Else If Label.BackColor = Color.Green Then Label.BackColor = Color.Transparent


        Next Label
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        For Each Label As Control In GroupBox1.Controls
            Label.BackColor = Color.Transparent

        Next Label
        If CheckBox1.Checked = True Then CheckBox1.Checked = False
        If CheckBox2.Checked = True Then CheckBox2.Checked = False
        If CheckBox3.Checked = True Then CheckBox3.Checked = False
        If CheckBox4.Checked = True Then CheckBox4.Checked = False
        If CheckBox5.Checked = True Then CheckBox5.Checked = False
        If CheckBox6.Checked = True Then CheckBox6.Checked = False
        If CheckBox7.Checked = True Then CheckBox7.Checked = False

    End Sub

    Private Sub Label49_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Spiritboxinfo.Click
        infobox.Clear()
        infobox.AppendText("A piece of equipment that can be used to ask the ghost questions to get more information. Only some ghosts will respond via the spirit box, which can be used as evidence when identifying the ghost.
Spirit Box can capture radio frequencies that allow for communication with spirits.

How to Use
To use the Spirit Box, you must be in the same room as the ghost, or within 3 meters if not in the same room, for it to answer. Lights must be off. Shy ghosts will require you to be the only person in the room. However, they will sometimes respond when a group is entering a room because it only detects one player.
The spirit box will still work if thrown on the ground as long as it is left on, and you are within range to ask questions and hear the responses. Sometimes, ghosts respond to spirit boxes placed on the ground without players directly trying to get a response with voice commands. Though ghosts can hear when you are talking no matter what, you must be using proximity chat for the spirit box to hear you.
Even though the Spirit Box requires a dark room, glowsticks do not count to that requirement.

There are four types of questions you can ask. If the spirit box does not respond with a message or 'Nothing detected', Your microphone is not working, or you did not ask one of the supported questions.
-Difficulty
-Location
-Age
-Personal")
    End Sub

    Private Sub Fingerprintsinfo_Click(sender As Object, e As EventArgs) Handles fingerprintsinfo.Click
        infobox.Clear()
        infobox.AppendText("A ghost will leave behind a finger print when it does the following:
Interacts with a door.
Interacts with a light switch.
Knocks on a window.
If you take a picture, it will count as interaction/fingerprints.
Note that when the ghost flickers the lights, or touches the Fuse Box, they will not always leave behind a fingerprint.
You can see fingerprints by using the UV Light or the Glowstick
Footprints, as opposed to fingerprints and handprints, DO NOT count as evidence")
    End Sub

    Private Sub Ghostwritinginfo_Click(sender As Object, e As EventArgs) Handles ghostwritinginfo.Click
        infobox.Clear()
        infobox.AppendText("Ghost Writing Book, also known as automatic writing, is the equipment used to obtain Ghost Writing by placing it near a ghost.

Trivia
Demons tend to write in the book earlier in hunts as compared to other entities but are still never guaranteed to do so. Demons, like any other entity, can decide to never write in the book.
The different writings displayed in the book once written in sometimes may clue into the type of ghost at play but are also sometimes purposefully misleading. Occult symbols will not always denote a Demon for example, but can usually highlight the probability of one.
There is no way to forcefully trigger the book to be written in legitimately.
No mechanics currently seem to exists that limit a ghost's abilities to write in the book.
-It can be written while being held.
-It can be written in while in light or darkness.
-It can be written in while in view of the player.
-It does not have to be right-side up.
-It can be written in while in the player's inventory, it doesn't have to be held out.
Taking pictures with a Photo Camera of the book once written in does not give extra photo money.
If placed within the vision of an active Video Camera, you can use the truck's monitor to see if writing has appeared.")
    End Sub

    Private Sub Label49_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Freezingtempsinfo_Click(sender As Object, e As EventArgs) Handles freezingtempsinfo.Click
        infobox.Clear()
        infobox.AppendText("Freezing temperatures can be discovered with a thermometer (0°C/32°F) or by seeing your breath. Sometimes you can see your breath for only a moment, and that is not necessarily evidence of freezing temperatures. (possible bug) ")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        infobox.Clear()
        infobox.AppendText("A Crucifix Is used to stop Ghosts from entering their physical form to attack you. It's advised to place them near the Ghost.
        The Crucifix Is a purchasable item that Is used to prevent the Ghost from entering into a Hunt.

How it works
For the Crucifix To successfully prevent a hunt, it must be In the vicinity Of the ghost When it starts the hunt. The Crucifix has a range Of 3 meters For most ghosts And 5 meters For the Banshee. When the ghost initiates the hunt, it checks To see If it Is In range Of a crucifix. If it Is, the hunt does Not begin, reverting the ghost into a passive state.

If the Then ghost Is out Of range Of the Crucifix (even If the Crucifix Is located In the Ghost Room), it may initiate a hunt As per normal. No sound Or animation will occur When the crucifix blocks a hunt. It will simply disappear once both charges have been used.

the Crucifix must be within the range of the ghost's hunting spawn location to work. Because of this, the Crucifix isn't always reliable, because ghosts may spawn a random, short distance away from their 'center point' ghost room. For example, if a ghost spawns for a hunt just out-of-range of a Crucifix, the hunt will proceed as normal.")
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        infobox.Clear()
        infobox.AppendText("Burning smudge sticks near a ghost will prevent it from attacking for a period of time.
Smudge Sticks are a purchasable item that when burned, will deter the Ghost from hunting or attacking for a period of time.

The Yurei and Spirit have special interactions with smudge sticks.

How it works
To use Smudge Sticks, you must interact with it using either a Lighter or a lit Candle. (Alternatively, if you have a lighter in your inventory, you can switch to the smudge sticks and press the 'F' key to light them automatically.)

Once lit, the Smudge Sticks will begin to smoke for roughly 15 seconds, and if the Ghost is within 6 meters, Ghost Activity will be increased marginally, and the Ghost won't be able to enter a hunt for 90 seconds (180 for Spirit). This won't stop an active hunt. The Smudge Stick will function both whiles in hand, or on floor.

If there is an active hunt, then the ghost will stop chasing a player and begin to wander for 6 seconds, before returning to hunting.

If the ghost is a Yurei, it will stop chasing and wander for 90 seconds.

You will know if the smudge sticks have worked due to the smoke dissipating, at this point you can throw the item down since it has been used up. If the smoke is still ongoing, it has yet to take effect.")
    End Sub

    Private Sub Button9_Click_1(sender As Object, e As EventArgs) Handles Button9.Click
        infobox.Clear()
        infobox.AppendText("🔼 Although the Spirit has no real strengths, having no unique characteristics often makes players misidentify them for another ghost. 
🔽 Using Smudge Sticks on a Spirit will stop it attacking for twice as long as other types of Ghost.

A Spirit is the most common Ghost you will come across however it is still very powerful and dangerous. They are usually discovered at one of their hunting grounds after an unexplained death.
With no special powers and a harsh reaction to Smudge Sticks, Spirits serve as a baseline to measure other Ghosts against. Their lack of any defining traits can trip up newer investigators, as Spirits can be mistaken for other ghost types until the Evidence starts piling up.

Evidence:
Ghost Writing
Spirit Box
EMF Level 5")
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        infobox.Clear()
        infobox.AppendText("🔼 Wraith almost never touches the ground meaning it can't be tracked by footsteps. The Wraith possesses both the power of flight and intangibility. It can travel through walls and doors without opening them, and will not leave footprints on the ground.
🔽 Wraith has a toxic reaction to Salt. If a Wraith comes into contact with a pile of salt, it will immediately cease attacking.

A Wraith is one of the most dangerous Ghosts you will find. It is also the only known ghost that has the ability of flight and has sometimes been known to travel through walls.
Wraiths are one of the 12 types of Ghosts that can be encountered in Phasmophobia, and the second one described in the Journal.

Evidence:
EMF Level 5
Spirit Box
D.O.T.S. Projector

Power:
The Wraith's power is that it will teleport onto a random player in the Ghost Room, and will emit an interaction with EMF reader.

Additional Notes:
Although Salt can make a Wraith stop attacking, it will also permanently increase Ghost Activity.
The Wraith will hover without touching the ground for long periods of time, but it occasionally takes steps on the ground. This means that the Wraith can still be tracked with salt to some degree. If salt is placed in a doorway, most times it will fly over the salt leaving a handprint on the door.
The Wraith is also unfazed by doors and lockers, especially during a Hunt. A Wraith cannot see doors or lockers, and can simply phase through them or spot players behind them. Keep this in mind during Hunts, as it can also wander into any room even if the door is closed after manifesting.

Strategies:
Due to the Wraith's aversion to salt, placing piles of it on the way to your exit will force the wraith to stop attacking. This is particularly useful in the wraith's case because it's the most proficient at finding players who are hiding in rooms and closets.")
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        infobox.Clear()
        infobox.AppendText("🔼 Looking at a Phantom will considerably drop your Sanity.
This refers to any visible manifestations of the Phantom, including during a Hunt.
🔽 Taking a photo of the Phantom will make it temporarily disappear. but it will not stop a Hunt.

A Phantom is a Ghost that can possess the living, most commonly summoned by an Ouija Board. It also induces fear into those around it.
Phantoms are one of the 12 types of Ghosts that can be encountered in Phasmophobia, and the third one described in the Journal. Contrary to popular belief, the Phantom cannot possess ghost-hunters after using an Ouija Board.

Evidence:
Fingerprints
Spirit Box
D.O.T.S. Projector

Lore:
A phantom, overall, is simply another term for a ghost.
Etymology-wise, Phantom pulls from as early as Greece with the word φᾰντᾰ́ζω, or phantasma, which stands for an apparition or a ghost. it could also be translated to something that isn't real in general, like a dream or an illusion.
As such, phantoms in most tales typically elaborate more on the concept of being an illusion version of something that already exists.")
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        infobox.Clear()
        infobox.AppendText("🔼 Poltergeist is capable of influencing more objects at once than any other ghosts and is capable of shutting multiple doors at once.
🔽 Poltergeist is almost ineffective in an empty room.

One of the most famous Ghosts, a Poltergeist, also known as a noisy ghost can manipulate objects around it to spread fear into its victims.

Evidence:
Spirit Box
Ghost Writing
Fingerprints

Additional Notes:
Poltergeist's ability to manipulate objects, specifically doors, can make it easier to identify. However, if the ghost is one that specifically affects multiple light fixtures and other electronics at once, it's more likely to be a Jinn.

Unlike other ghosts, objects thrown by Poltergeists have the ability to decrease player sanity if they were not looking at the objects being thrown. This can also help to identify the ghost; if a player notices a dip in their sanity after they hear physical disturbances in nearby rooms, they can guess it is likely a Poltergeist they are facing.

An unwritten quirk of the Poltergeist is that they have the greatest capacity to roam from their Ghost Room, going far to move objects away from its space. In larger maps, this can result in red herrings when looking for Ghost Activity and cause players to waste time searching areas that ultimately do not house the Poltergeist.

The Poltergeist is the sole ghost that can be identified with only 2 pieces of evidence - the Ghost Orb and Fingerprints.")
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        infobox.Clear()
        infobox.AppendText("🔼 Banshee will focus on one player at a time until it kills them.
🔽 Banshee is afraid of the Crucifix, which boosts the Hunt-stopping range of one from 3 meters to 5 meters against it.

The Banshee is a natural hunter and will attack anything. It has been renowned to stalk its prey one at a time until it makes its kill.

Unlike other ghosts, who will often change their selected target between Hunts, Banshees will always target the same player every time it hunts until it successfully kills them. While this means other players are safe from the Banshee's power as long as its target is alive, it makes carrying out objectives by the targeted player more difficult.

Evidence:
D.O.T.S. Projector
Ghost Orb
Fingerprints

Power:
Once a banshee uses its power, it will begin to navigate to its chosen target. Line-of-sight blockers and hiding have no effect on the Banshee's ability to navigate to the player, and it will be able to reach them. After reaching the player, it will wait ~20 seconds, then proceeds to begin a hunt if the player is not within direct line-of-sight of the Banshee.
The Banshee will cancel its ability if its target is not in the building.
A Banshee's power is particularly dangerous, as it is capable of hunting players that are very far away from the ghost room who think they are safe, even on the largest of maps. A Banshee that uses its power to hunt before the ghost room is located can also trick players into thinking the ghost room is close, as they hear the ghost nearby when in reality the Banshee has just walked from a different location of the map to the player.
The Banshee's power ignores sanity and typical hunting rules, meaning it can potentially begin a hunt with its power within moments of the hunters entering the location on the professional or intermediate difficulty. A hunt beginning very early on while all players have high sanity could be a sign of a banshee using its power.

Strategies:
Due to the Banshee's focus on a single-player character, determining who the targeted player is early on can trivialize most rounds by having the target hide far away from the Banshee to lower its chances of ever actually killing its target. However, this requires all players to survive the hunt lest the Banshee acquires a new target, starting the process all over again.")
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        infobox.Clear()
        infobox.AppendText("🔼 A Jinn will travel at a faster speed if its victim is far away.
🔽 Turning off the power source will prevent the Jinn from using its ability.

A Jinn is a territorial ghost that will attack when threatened. It has also been known to travel at significant speed during Hunts.

Jinns tend to interact with electronics more than any other ghost. They may cause phones to ring, radios to activate, TV's to turn on, or car alarms to go off more often. This also extends to light switches, which may cause unsure investigators to confuse a Jinn for a Mare or Poltergeist; although Mares also have the power to turn lights off, they will not turn lights back on as Jinn does, and Poltergeists will likely disturb more general objects that aren't light switches such as doors. It is also rumoured that a Jinn is the most common ghost, despite the book claiming it to be spirit.

Evidence:
EMF Level 5
Fingerprints
Freezing Temperatures

Strategies:
Turning off the power source will prevent the Jinn from moving fast during a hunt and makes it easier for players to see its ghost orbs.
Most Jinns will temporarily disappear if players stay out of its room, which means if evidence must be gathered, stepping into its area will greatly increase the chances of activity.
Especially-daring players can easily identify the Jinn with its behavior during a Hunt while the power is still on: although it is quick to catch up to players that it is chasing, it will slow down significantly as it approaches them, allowing players to re-establish a gap that the Jinn will speed up to close; correctly none of these will allow for the Jinn to be identified without a single piece of evidence needing to be gathered.")
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        infobox.Clear()
        infobox.AppendText("🔼 Increased chance to attack in the dark. As such, will do what it can to achieve this, such as turning off lights and tripping the power source.
🔽 Turning the lights on will lower its chance to attack.

In Phasmophobia, A Mare is the source of all nightmares, making it most powerful in the dark. As its description suggests, Mares have a higher chance of initiating hunts when players are in darkness. Mares tend to turn lights and the fuse box off more than any other ghost-type when active, although if a ghost switches lights back on, it is much more likely to be a Poltergeist or Jinn. An active Mare stalking low-sanity players have the capacity to initiate hunts within mere moments of each other, allowing them to rival even Demons in aggression.

Evidence:
Ghost Writing
Spirit Box
Ghost Orb

Strategies:
As the Mare's entire strategy revolves around keeping players in the darkness, the simplest solution is to keep the lights on in high-traffic areas such as near the front door and hallways.

Be aware of the locations of light switches and the power source, as the Mare will often work to turn them off, and keeping a paranormal investigator near them will help counteract the Mare's habits.")
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        infobox.Clear()
        infobox.AppendText("🔼 A Revenant will travel at a significantly faster speed when hunting a victim. Additionally, the Revenant can freely switch whoever it is targeting during a Hunt.
🔽 Hiding from the Revenant will cause it to move very slowly.

The Revenant is a slow but violent ghost that will attack indiscriminately. It is said to travel at higher speed when hunting.

Unlike other Ghosts, who will have a specific target selected when starting a Hunt they will hone in on (especially Banshees), Revenants can freely switch targets if there is another player that is closer by and especially one that is in plain view and available, making its goal of killing players more convenient.

Evidence:
Ghost Orb
Ghost Writing
Freezing Temperatures")
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        infobox.Clear()
        infobox.AppendText("🔼 As a shy ghost, a Shade will rarely perform actions in the presence of two or more people, making it harder to detect.
🔽 Conversely, a Shade will rarely start a Hunt when players are grouped together.

Noted as being shy ghosts, Shades lower their activity in the presence of multiple investigators. Because of its temperament, it can be harder to find ghost activity when sticking together. However, like all ghosts in the game, the Shade is more likely to hunt when the players' sanity is low.

If a Shade is already hunting, it will prefer to target players that are alone. For it to consider a player alone, the other players have to be in a separate room, though they do not have to be far away.

Evidence:
EMF Level 5
Ghost Writing
Freezing Temperatures

Strategies:
Due to a Shade's aforementioned shyness, players are left with a hard choice: either stick together to eliminate risks, or go alone to let the Shade do something. Players who are currently alone should exercise caution, especially since the Shade will likely begin Hunting once players are alone.

Players should work together as a group to find the Ghost Room first and foremost, especially on Professional difficulty when there is no Setup Phase. Bringing a Crucifix and Smudge Sticks will help prevent attacks if the team splits up to let the Shade perform more activity.")
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        infobox.Clear()
        infobox.AppendText("🔼 Demon will attack more often than any other ghost.
🔽 Asking a Demon successful questions on the Ouija Board won't lower the users' sanity.

In Phasmophobia, Demons are one of the most dangerous ghosts to encounter. Highly aggressive, it will attack more often than any other ghost, and without warning so a crucifix is recommended to prevent hunts. However, it will also allow ghost hunters to use the Ouija Board without reducing their sanity.

If the investigation and objectives are not dealt with quickly, Demons can grow to be the most challenging ghost. They are notorious for initiating hunts frequently, a trait that is exacerbated by lower sanity levels, and compounded by higher difficulties like Professional where hunts last much longer. Taking all of these factors into account, Demons at their most aggressive will hunt in intervals as short as half-minutes, forcing the players to spend more total time hiding than investigating.

With this in mind, it is tantamount that players move as quickly and efficiently in gathering evidence as possible, and bring sanity pills, crucifixes, and other defensive equipment to keep a Demon from reaching its full power. Taking advantage of a Demon's known weakness with Ouija Boards can net players the information they need to succeed, mainly finding out its Ghost Room without needing to waste time searching.

Evidence:
Freezing Temperatures
Ghost Writing
Fingerprints")
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        infobox.Clear()
        infobox.AppendText("🔼 Yurei have been known to have a stronger effect on people's sanity.
🔽 Using Smudge Sticks on the Yurei's room will cause it to not wander around the location for a long time.

Yurei is a ghost that has returned to the physical world, usually for the purpose of revenge or hatred.

Evidence:
Freezing Temperatures
D.O.T.S. Projector
Ghost Orb")
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        infobox.Clear()
        infobox.AppendText("🔼 Oni is more active when people are nearby and have been seen moving objects at great speed.
🔽 Being more active will make the Oni easier to find and identify.

The Oni is a cousin to the Demon and possesses extreme strength. There have been rumours that they become more active around their prey.

Evidence:
EMF Level 5
Freezing Temperatures
D.O.T.S. Projector")
    End Sub

    Private Sub EMF5info_Click(sender As Object, e As EventArgs) Handles emf5info.Click
        infobox.Clear()
        infobox.AppendText("The Electro-Magnetic Field Reader is a handheld device used to detect fluctuations in electromagnetic fields left behind by paranormal activity. It will beep with increasing volume depending on the amount of activity nearby.
An EMF Reader is a purchasable piece of equipment used to read the current EMF in the location. It consists of a small white box with 5 lights. 2 green, 1 yellow, 1 orange and 1 red. When the item is turned on, the first light will light up.

As the ghost manifests, it will emit a reading based on the ghost's interaction with items, and a tone will play (doors, Ouija Board, Dirty water, etc.).

It is the only way to determine if the Ghost produces an EMF Level 5 evidence.

If there are multiple EMF emissions in a location, it will show the stronger one.

The EMF reader can be dropped on the floor and is recommended to crouch and throw the EMF reader at a flatter trajectory, or straight down to prevent the EMF reader flipping over. While not in hand, the EMF reader gets a detection buff.

Trivia
EMF readers are in no way tied to Site Activity Monitor. An EMF Level 5 does not denote an activity level of at least 5, and vice-versa, an activity level of 5 will not denote an EMF level 5. These mechanics are independently functional.
An EMF reading of 4 does not always denote or void out the existence of an EMF Level 5 clue. EMF 5 can prove to be very location-sensitive, oftentimes requiring you to pinpoint a specific location within the Ghost Room during elevated activity. Usually, this is a location the ghost has actively been standing in.
Use of Motion Sensors, and consulting the Site Activity Monitor, can be used to be pinpoint locations where the ghost has been, and at what times it may give an active reading.
EMF level 5 doesn't always mean danger. It just means high activity. Inversely, dangerous scenarios will often not trigger EMF readings, and when it does, they're still not likely to be EMF 5.
During a hunt, the ghost cannot see an active EMF reader being held, but should it start going off, it can be heard. Toggling the EMF has also proven to make close-range noise. As the saying goes, 'If another player can hear it, it can be heard by the ghost'.
Like any tool, to silently disable the item, swap to an inactive item or empty hand.
If placed within the vision of an active Video Camera, the EMF reader's level can be read safely from inside the truck. Photographing an image of it on the truck's computer screen will not count as evidence.")
    End Sub

    Private Sub Ghostorbinfo_Click(sender As Object, e As EventArgs) Handles ghostorbinfo.Click
        infobox.Clear()
        infobox.AppendText("Ghost Orbs are a type of Evidence which are emitted from the Ghost Room, and look like very small yellow floating orbs. They can be seen on the computer screen using a Video Camera or a Head Mounted Camera with night vision. Camera placement is key to detecting ghost orbs. Once the ghost room/area is found, a good strategy to use is placing two cameras in the corners of the room facing each-other to maximize coverage, or outside the room pointing in. It's also a good idea to place one or more cameras outside the room to catch the ghost if it roams.")
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        infobox.Clear()

    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        infobox.Clear()
        infobox.AppendText("I got most of this information from https://steamcommunity.com/sharedfiles/filedetails/?id=2267517404 and https://steamcommunity.com/sharedfiles/filedetails/?id=2263827459&insideModal=0

Big Thanks to Marvin Poling for taking my basic Excel of this project and creating it into a program for me to make snazzy, and my friends for helping me figure it out and make it better :)")
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        ComboBox1.Items.Clear()
        ComboBox1.ResetText()
        TextBox1.Clear()
        ComboBox2.Items.Clear()
        ComboBox2.ResetText()
        ComboBox3.Items.Clear()
        ComboBox3.ResetText()


    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        infobox.Clear()
        infobox.AppendText("🔼A Goryo Will usually only show itself on camera if there are no people nearby.
🔽They are rarely seens far from their place of death.

Using a Video Camera is the only way to view a Goryo, when it passes through a D.O.T.S. Projector.

Evidence: 
EMF Level 5
Fingerprints
D.O.T.S. Projector")
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        infobox.Clear()
        infobox.AppendText("🔼A Myling is known to be quieter when hunting.
🔽Mylings more frequently make paranormal sounds.

A Myling is a very vocal and active ghost. They are rumoured to be quiet when hunting their prey.

Evidence:
EMF Level 5
Fingerprints
Ghost Writing")
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        infobox.Clear()
        infobox.AppendText("🔼 Talking near a Yokai will anger it and increase its chance of attacking.
🔽 When hunting, a Yokai can only hear voices close to it.

Evidence:
Spirit Box
Ghost Orb
D.O.T.S. Projector")
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        infobox.Clear()
        infobox.AppendText("🔼 Lower temperatures can cause the Hantu to move at faster speeds.
🔽 A Hantu will move slower in warmer areas.

Evidence:
Fingerprints
Ghost Orb
Freezing Temperatures")
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        infobox.Clear()
        infobox.AppendText("A laser grid of light that can reveal the silhouette of a ghost. (will add more info once I figure it out, sorry.)")
    End Sub
End Class

