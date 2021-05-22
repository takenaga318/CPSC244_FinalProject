Identifying Information:
1. Game Title:  Detective of Willowdale
2. Team Member Names:
   1. Audrey Takenaga
   2. Michael Woodward
   3. Macy Werner
   4. Anna Wren
   5. Isabella Sills
3. Course Number and Section: 244-01
4. Assignment: Final Project


Source Files Submitted:
1. Creator Kit RPG Scripts
2. DontDestroy.cs
3. VectorValue.cs
4. SceneTransition.cs


Project Files Submitted:
1. DetectiveOfWillowdale_Final.zip (project folder)
2. DetectiveOfWillowdale_Final. (project build)
3. DetectiveOfWillowdale_Final.pdf (design doc)


Description of any known compile/runtime errors, or bugs
1. Quests are not preserved in between scenes (really couldn't figure it out)
   1. Used Don’tDestroyOnLoad (didn’t work) and tried static on isStarted and isFinished (realized it wouldn’t work across different instances of object)
   2. HIGHLY RECOMMENDED: That rooms are not entered during quest duration
      1.  You can go into all the scenes and interact with NPCs in them, but do not do it in the middle of a quest given by an NPC.
      2. Otherwise NPCs may despawn (that were spawned on the quest start)
      3. And Conversations will have to be restarted
   3. Very unfortunate bug

References used to complete the assignment:
1. https://itch.io/game-assets/free/tag-tilemap
   1. Inside Building tilemaps
   2. Building tilemaps
2. https://youtu.be/JcEJtEWjiZU?list=PLwoIj2DZp0Bm_WIU31KxmlaM7t66JW9uX
   1. Fading between scenes
3. https://youtu.be/wNl--exin90?list=PLwoIj2DZp0Bm_WIU31KxmlaM7t66JW9uX
   1. Switching between scenes
4. https://answers.unity.com/questions/747603/how-does-dontdestroyonload-work-1.html
   1. Tried to implement this on NPC gameObjects

Instructions to Run:
1. Load Project
2. Click Play
